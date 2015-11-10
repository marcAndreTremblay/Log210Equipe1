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

namespace GestionnaireLivre.Forms.UtilityUC
{
    public partial class BookInfoPanelUC : UserControl
    {
        public delegate void OnBookReservedEvent(Book  sender, EventArgs e);
        public event OnBookReservedEvent OnBookReserved;

        Book currentBook;
        public BookInfoPanelUC(Book book ,Image thumbnail)
        {
            currentBook = book;
            InitializeComponent();

            LTitle.Text = book.Title + " ("+book.Language+")";
            LPrice.Text = book.price + "$";
            LAuthor.Text = book.Author;
            LCondition.Text = book.bookconditionDescription;
            if (book.FK_transactionType == 1) this.BackColor = Color.SteelBlue;
            if (book.FK_transactionType == 2) this.BackColor = Color.Orange;
            LCoopName.Text = book.coopName;
            LLanguage.Text = book.Language;
          

        }

        private void ButtonReserve_Click(object sender, EventArgs e)
        {
            if(OnBookReserved != null)
            {
                OnBookReserved(currentBook, e);
            }
        }
    }
}
