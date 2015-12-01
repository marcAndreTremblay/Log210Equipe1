using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Model.DataObject;
using GestionnaireLivre.Forms.UtilityUC;
using System.Net.Mail;

namespace GestionnaireLivre.Forms.MainWindowUC
{
    public partial class BookReceptionUC : UserControl
    {
        private DataBaseService dBService;
        private User loggedUser;
        private List<Book> bookList;
        private List<Book> bookRecevied;
        private List<BookCondition> bookConditionList;
        private User clientUser;

        public BookReceptionUC(DataBaseService dBService, User loggedUser)
        {
            this.dBService = dBService;
            this.loggedUser = loggedUser;
            InitializeComponent();

            //Init comboBox
            List<BookCondition> bookCondition = dBService.BookCondition;
            foreach (BookCondition bc in bookCondition)
            {
                comboBBookCondition.Items.Add(bc);
            }

            bookList =  new List<Book>();
            bookRecevied = new List<Book>();
            bookConditionList = dBService.BookCondition;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (searchTypeCB.SelectedItem != null)
            {
                switch (searchTypeCB.SelectedItem.ToString())
                {
                    case "Client name":
                        searchByClientName(searchTB.Text);
                        break;
                    case "Title":
                        searchByTitle(searchTB.Text);
                        break;
                    case "ISBN":
                        searchByISBN(searchTB.Text);
                        break;
                    case "UPC":
                        searchByUPC(searchTB.Text);
                        break;
                }
            }
            else
            {
                //Show Select a search type
                labelSearchError.Text = "Select a search type";
                labelSearchError.Visible = true;
                this.Update();
            }
        }
        
                
        private void searchByClientName(String clientName)
        {
            int id = 0;
            List<User> userList = dBService.SearchUserByName(clientName);
            List<Book> tmpBookList = new List<Book>();
            
            if (userList.Count != 0)
            {
                //Hide no result found error
                labelSearchError.Visible = false;
                this.Update();

                clientUser = userList.ElementAt(0);
                tmpBookList = dBService.RetriveBookBySellerId(userList.ElementAt(0).Id);

                foreach (Book currentBook in tmpBookList)
                {
                    if (currentBook.FK_coop_ref == loggedUser.CoopRefID && currentBook.FK_transactionStatus == 1)
                    {
                        ListViewItem currentItem = new ListViewItem(id++.ToString());
                        currentItem.SubItems.Add(currentBook.Title);
                        currentItem.SubItems.Add(currentBook.ISBN);
                        currentItem.SubItems.Add(clientName);
                        currentItem.SubItems.Add(currentBook.bookconditionDescription);
                        searchResultLV.Items.Add(currentItem);
                        bookList.Add(currentBook);
                    }
                }
            }
            else
            {
                //Show no result found error
                labelSearchError.Text = "No book found";
                labelSearchError.Visible = true;
                this.Update();
            }
        }

        private void searchByTitle(String title)
        {
            int id = 0;
            List<Book> tmpBookList = dBService.SearchBook(title, null, null, null);

            showSearchResult(tmpBookList, "clientName");
        }

        private void searchByISBN(String ISBN)
        {
            List<Book> tmpBookList = dBService.SearchBook(null, null, null, ISBN);

            showSearchResult(tmpBookList, "clientName");
        }

        private void searchByUPC(String UPC)
        {
            List<Book> tmpBookList = dBService.SearchBook(null, null, UPC, null);

            showSearchResult(tmpBookList, "clientName");
        }

        private void showSearchResult(List<Book> tmpBookList, String clientName)
        {
            int id = 0;

            if (tmpBookList.Count != 0)
            {
                //Hide no result found error
                labelSearchError.Visible = false;
                this.Update();

                foreach (Book currentBook in tmpBookList)
                {
                    if (currentBook.FK_coop_ref == loggedUser.CoopRefID && currentBook.FK_transactionStatus == 1)
                    {
                        ListViewItem currentItem = new ListViewItem(id++.ToString());
                        currentItem.SubItems.Add(currentBook.Title);
                        currentItem.SubItems.Add(currentBook.ISBN);
                        currentItem.SubItems.Add("clientName");
                        currentItem.SubItems.Add(currentBook.bookconditionDescription);
                        searchResultLV.Items.Add(currentItem);
                        bookList.Add(currentBook);
                    }
                }
            }
            else
            {
                //Show no result found error
                labelSearchError.Text = "No book found";
                labelSearchError.Visible = true;
                this.Update();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (searchResultLV.Items.Count != 0)
            {

                if (comboBBookCondition.SelectedItem != null)
                {
                    //Hide error message
                    labelValidationError.Visible = false;
                    this.Update();

                    int id = Int32.Parse(searchResultLV.SelectedItems[0].SubItems[0].Text);
                    Book selectedBook = bookList.ElementAt(id);
                    int validatedCondition = comboBBookCondition.SelectedIndex + 1;

                    //Update book condition if not the same
                    if (selectedBook.FK_bookcondition != (validatedCondition))
                    {
                        dBService.UpdateSpecificBookCondition(selectedBook, bookConditionList.ElementAt(validatedCondition - 1));
                    }

                    //Change book status
                    dBService.ValidateSpecificBookCondition(selectedBook);

                    bookRecevied.Add(selectedBook);
                    //bookList.RemoveAt(id);

                    searchResultLV.Items.Clear();
                    searchResultLV.Refresh();
                }
                else
                {
                    //Show Validate the book condition
                    labelValidationError.Text = "Validate the book condition";
                    labelValidationError.Visible = true;
                    this.Update();
                }
            }
            else
            {
                //Show Select a book
                labelValidationError.Text = "Select a book";
                labelValidationError.Visible = true;
                this.Update();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(searchResultLV.SelectedItems[0].SubItems[0].Text);
            Book selectedBook = bookList.ElementAt(id);
            dBService.RemoveSpecificBook(selectedBook);
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (bookRecevied.Count != 0)
            {
                sendMail();
            }
            
            clearAll();
        }

        private void sendMail()
        {
            String body = "Hi, we have well recevied those books:";
            MailMessage mail = new MailMessage("etienne.lalumiere.1@gmail.com", clientUser.EmailAdress);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.google.com";
            mail.Subject = "New book reception";
            foreach(Book book in bookRecevied)
            {
                body = body + " " + book.Title;
            }
            body = ".";
            mail.Body = body;
            client.Send(mail);
        }

        private void clearAll()
        {
            searchTB.Clear();
            searchTB.Refresh();
            searchResultLV.Items.Clear();
            searchResultLV.Refresh();
        }
    }
}
