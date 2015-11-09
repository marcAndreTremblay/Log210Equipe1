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

namespace GestionnaireLivre.Forms.MainUserControl
{
    public partial class ClientHomeUC : UserControl
    {
        DataBaseService DBService;

        public ClientHomeUC(DataBaseService dbService)
        {
            DBService = dbService;
            InitializeComponent();
           


            foreach(Book current in DBService.RetriveBookBySellerId(DBService.loginID))
            {
                
                switch(current.FK_transactionStatus)
                {
                    case 1:
                        {
                            BookClientInfoUC newPanel = new BookClientInfoUC(current); 
                            FLPWaitDeposit.Controls.Add(newPanel); } break;
                    case 2:
                        {
                            BookClientInfoUC newPanel = new BookClientInfoUC(current);
                            FLPOnSale.Controls.Add(newPanel);
                        } break;
                    case 3:
                        {
                            BookClientInfoUC newPanel = new BookClientInfoUC(current);
                            FLPWaitPickup.Controls.Add(newPanel);
                        } break;
                    case 4: { } break;
                }
            }
        }
    }
}
