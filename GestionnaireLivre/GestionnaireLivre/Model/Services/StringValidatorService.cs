using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Net.Mail;

namespace GestionnaireLivre.Model.Services
{
    public static class StringValidatorService
    {

        public static bool IsValidEmailAdress(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

    }
}
