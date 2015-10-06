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

namespace GestionnaireLivre.Forms.MainUserControl
{
    public partial class ClientHomeUC : UserControl
    {
        DataBaseService DBService;

        public ClientHomeUC(DataBaseService dbService)
        {
            DBService = dbService;
            InitializeComponent();
        }
    }
}
