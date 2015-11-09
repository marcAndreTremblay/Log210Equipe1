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

namespace GestionnaireLivre.Forms.MainUserControl
{
    public partial class SearchBookUC : UserControl
    {

        private DataBaseService DBService;
        
        public SearchBookUC(DataBaseService dbService)
        {
            DBService = dbService;
            InitializeComponent();


            foreach(Book currentBook in DBService.RetriveAllBooks())
            {
                //FLPBookSearchResult.Controls.Add();
            }

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            List<Book> bookResult;
            if (TBSearchTitle.Text != "")
            {
                bookResult = DBService.SearchBookByTitle("%"+TBSearchTitle.Text + "%");
            }

           
        }
    }
}
