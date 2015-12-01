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

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
