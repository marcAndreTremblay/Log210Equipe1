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

            

            foreach(Book currentBook in DBService.RetriveAllBooks())
            {
                BookInfoPanelUC panel = new BookInfoPanelUC(currentBook, null);
                panel.OnBookReserved += OnBookReserveClick;
                FLPBookSearchResult.Controls.Add(panel);                            
            }

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            List<Book> bookResult;
            if (TBSearchTitle.Text != "")
            {
                bookResult = DBService.SearchBook(TBSearchTitle.Text,"","","");
            }

           
        }

        private void OnBookReserveClick(Book sender,EventArgs e)
        {

        }
    }
}
