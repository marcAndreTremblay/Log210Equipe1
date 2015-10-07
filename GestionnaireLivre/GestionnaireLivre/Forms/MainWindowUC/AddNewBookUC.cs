using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Books.v1.Data;
using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Forms.UtilityUC;
using System.Threading;


using GestionnaireLivre.Model.DataObject;

namespace GestionnaireLivre.Forms.MainWindowUC
{
    public partial class AddNewBookUC : UserControl
    {


        DataBaseService DataBService;
        BookSeachService BookSService;

        BookPreviewUC bookPreview;
        Task<Volume> bookSearchTread;
        Point bookPreviewLocation = new Point(420, 10);

        public AddNewBookUC(DataBaseService _dbService, BookSeachService _bookSeachService)
        {
            DataBService = _dbService;
            BookSService = _bookSeachService;
            InitializeComponent();
            List<Cooperative> cooperative = DataBService.RetrieveCooperatives();
            foreach (Cooperative coop in cooperative)
            {
                comboBoxCooperative.Items.Add(coop);
            }
            List<BookCondition> bookCondition = DataBService.BookCondition;
            foreach(BookCondition bc in bookCondition)
            {
                comboBBookCondition.Items.Add(bc);
            }
            List<TransactionType> bookState = DataBService.BookTransactionType;
            foreach (TransactionType tt in bookState)
            {
                comboBBookState.Items.Add(tt);
            }
         
            
            ClearPage();
        }

        private bool IsTextAllNumerical(string text)
        {
            bool isAllNumerical = true;
            foreach (char c in textBoxCodeISBN.Text)
            {
                if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9'))
                {
                    isAllNumerical = false;
                    break;
                }
            }
            return isAllNumerical;
        }
        private void ClearPage()
        {
            textBoxBookName.Text = "";
            textBoxAuthor.Text = "";
            textBoxCodeISBN.Text = "";
            textBoxCodeISBN.BackColor = Color.White;
            textBoxLanguage.Text = "";
            textBCategorie.Text = "";
            textBoxPublisher.Text = "";
            textBPriceTag.Text = "";
            labelErrorSearch.Visible = false;
            buttonSearchISBN.Visible = false;
            buttonFIFM.Visible = false;

            comboBBookState.SelectedIndex = 0;
            comboBBookCondition.SelectedIndex = 0;
            comboBoxCooperative.SelectedIndex = 0;
            if (bookPreview != null)
            {
                bookPreview.Visible = false;
                this.Controls.Remove(bookPreview);
            }
            bookPreview = null;

            this.Invalidate(true);
        }
      
        
        
        private void textBoxCodeISBN_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxCodeISBN.Text.Length == 10 || textBoxCodeISBN.Text.Length == 13)
            {
                if (IsTextAllNumerical(textBoxCodeISBN.Text) == true)
                {
                    textBoxCodeISBN.BackColor = Color.LightGreen;
                    buttonSearchISBN.Visible = true;
                }
            }
            else
            {
                buttonSearchISBN.Visible = false;
                textBoxCodeISBN.BackColor = Color.Red;
            }
        }



        private void buttonSearchISBN_Click(object sender, EventArgs e)
        {
            bookSearchTread = BookSService.SearchBookISBN(textBoxCodeISBN.Text);
        }

        private void timerSearchBook_Tick(object sender, EventArgs e)
        {
            if(bookSearchTread != null)
            {
                if(bookSearchTread.IsCompleted)
                {
                    if (bookSearchTread.Result != null)
                    {
                        bookPreview = new BookPreviewUC(bookSearchTread.Result);
                        bookPreview.Location = bookPreviewLocation;
                        showBookPreview(bookPreview);
                        labelErrorSearch.Visible = false;
                    }
                    else
                    {
                        labelErrorSearch.Visible = true;
                    }                                    
                }
            }
        }

        private void showBookPreview(BookPreviewUC newPreview)
        {
            if(bookPreview != null)
            {
                this.Controls.Remove(bookPreview);
                bookPreview = null;
            }

            newPreview.Location = new Point(400, 10);
            this.Controls.Add(newPreview);
            bookPreview = newPreview;
            buttonFIFM.Visible = true;
        }

        private void buttonFIFM_Click(object sender, EventArgs e)
        {
            
            textBoxBookName.Text = bookSearchTread.Result.VolumeInfo.Title;
            textBoxPublisher.Text = bookSearchTread.Result.VolumeInfo.Publisher;
            textBoxLanguage.Text = bookSearchTread.Result.VolumeInfo.Language;

            if (bookSearchTread.Result.VolumeInfo.Authors != null)
            {
                textBoxAuthor.Text = bookSearchTread.Result.VolumeInfo.Authors.FirstOrDefault();
            }
            if (bookSearchTread.Result.VolumeInfo.Categories != null)
            {
                textBCategorie.Text = bookSearchTread.Result.VolumeInfo.Categories.FirstOrDefault();
            }
           
           
        }

        private void radioBExchange_CheckedChanged(object sender, EventArgs e)
        {
            panelSellPrice.Visible = false;
        }

        private void radioBSale_CheckedChanged(object sender, EventArgs e)
        {
            panelSellPrice.Visible = true;
        }

        private void buttonRegisterNow_Click(object sender, EventArgs e)
        {

            BookCondition bookcconditionSelected = (BookCondition)comboBBookCondition.SelectedItem;
            TransactionType bookTransactionTypeSelected = (TransactionType)comboBBookState.SelectedItem;
            Cooperative selectedCoop = (Cooperative)comboBoxCooperative.SelectedItem;

            NewBook newbook = new NewBook();
                newbook.Title = textBoxBookName.Text;
                newbook.Author =  textBoxAuthor.Text;
                newbook.ISBN = textBoxCodeISBN.Text;
                newbook.Language = textBoxLanguage.Text;
                newbook.Categorie = textBCategorie.Text;
                newbook.Publishier = textBoxPublisher.Text;
                newbook.price = Convert.ToInt32(textBPriceTag.Text);
                newbook.FK_bookcondition = bookcconditionSelected.id;
                newbook.FK_transactionType = bookTransactionTypeSelected.id;
                newbook.FK_coop_ref = selectedCoop.id;

                DialogResult result1 = MessageBox.Show("Confirme?",
                                                             "Important Question",
                                                             MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    bool result = DataBService.RegisterBook(newbook);
                    if(result == true)
                    {
                        ClearPage();
                    }
                }
        }


    }
}
