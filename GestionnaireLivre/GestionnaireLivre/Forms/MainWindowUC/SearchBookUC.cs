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

using GestionnaireLivre.Model.DataObject;
using GestionnaireLivre.Model.Services;
using GestionnaireLivre.Forms.UtilityUC;
using System.Threading;

namespace GestionnaireLivre.Forms.MainUserControl
{
    public partial class SearchBookUC : UserControl
    {
        private BookSeachService SeachService;
        private DataBaseService DBService;
        
        public SearchBookUC(DataBaseService dbService,BookSeachService seachService)
        {
            SeachService = seachService;
            DBService = dbService;
            InitializeComponent();

            foreach (Book currentBook in DBService.RetrieveLast10BookOnSale())
            {
                BookInfoPanelUC panel = new BookInfoPanelUC(currentBook, null);
                panel.OnBookReserved += OnBookReserveClick;
                FLPBookSearchResult.Controls.Add(panel);
            }
        }

        

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            List<Book> bookResult = DBService.SearchBook(TBSearchTitle.Text,TBSearchAuthor.Text,"",TBSearchISBN.Text);
            FLPBookSearchResult.Controls.Clear();
            foreach (Book currentBook in bookResult)
            {
                BookInfoPanelUC panel = new BookInfoPanelUC(currentBook, null);
                panel.OnBookReserved += OnBookReserveClick;
                FLPBookSearchResult.Controls.Add(panel);
            }
        }

        private void OnBookReserveClick(Book sender,EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to reserve : "+sender.Title +"?\n"
                                                   +"You will have 48 hours to pick it up at :" +sender.coopName +"\nPrice : "+sender.price+"$", "Important Question", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                DBService.ReserveSpecificBook(DBService.loginID, sender);
            }
        }
    }
}
