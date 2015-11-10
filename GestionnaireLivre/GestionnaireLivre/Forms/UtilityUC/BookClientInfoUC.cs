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
namespace GestionnaireLivre.Forms.UtilityUC
{
    public partial class BookClientInfoUC : UserControl
    {
        public BookClientInfoUC(Book book)
        {
            InitializeComponent();
            LAuthor.Text = book.Author;
            LTitle.Text = book.Title;
            LLanguage.Text = book.Language;
            LCondition.Text = book.bookconditionDescription;
            LPrice.Text = book.price.ToString() + "$";
        }
    }
}
