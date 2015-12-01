using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionnaireLivre.Model.DataObject;
using GestionnaireLivre.Model.Services;



using System.Net.Mail;
using System.Net;

namespace GestionnaireLivre.Forms.MainWindowUC
{
    public partial class BookDeliveryUC : UserControl
    {
        private DataBaseService dBService;
        private User loggedUser;
        private List<Book> bookList;


        public BookDeliveryUC(DataBaseService dBService, User loggedUser)
        {
            this.dBService = dBService;
            this.loggedUser = loggedUser;
            this.bookList = new List<Book>();

            InitializeComponent();

            List<Book> tmpBookList = dBService.RetrieveBooksByCoopId(loggedUser.CoopRefID);

            int id = 0;
            foreach (Book currentBook in tmpBookList)
            {
                if (currentBook.FK_transactionStatus == 3)
                {
                    User tests = dBService.RetrieveSpecificUser(currentBook.NewUserId);
                    ListViewItem currentItem = new ListViewItem(id++.ToString());
                    currentItem.SubItems.Add(currentBook.Title);
                    currentItem.SubItems.Add(currentBook.ISBN);
                    currentItem.SubItems.Add(tests.Name);
                    currentItem.SubItems.Add(currentBook.bookconditionDescription);
                    searchResultLV.Items.Add(currentItem);
                    bookList.Add(currentBook);
                }
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (searchResultLV.Items.Count != 0)
            {
                    this.Update();

                    int id = Int32.Parse(searchResultLV.SelectedItems[0].SubItems[0].Text);
                    Book selectedBook = bookList.ElementAt(id);

                    dBService.CompleteBookTransaction(selectedBook);               
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (searchResultLV.Items.Count != 0)
            {
                this.Update();
                if(searchResultLV.SelectedItems != null)
                {
                    int id = Int32.Parse(searchResultLV.SelectedItems[0].SubItems[0].Text);
                    Book selectedBook = bookList.ElementAt(id);

                    dBService.ValidateSpecificBookCondition(selectedBook);
                
                    sendMail(dBService.RetrieveSpecificUser(selectedBook.NewUserId).EmailAdress);
                }
                
            }
        }


        private void sendMail(string email)
        {
            var fromAddress = new MailAddress("log210automne2015@gmail.com", "");
            var toAddress = new MailAddress(email, "");
            const string fromPassword = "log2102015";
            const string subject = "Transaction annulé";
            string body = "Transaction annulé:";
           
           

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
