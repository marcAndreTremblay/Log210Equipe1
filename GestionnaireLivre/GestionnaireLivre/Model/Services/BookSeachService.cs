using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using System.Net;
using System.IO;
using System.Drawing;

namespace GestionnaireLivre.Model.Services
{
    public class  BookSeachService
    {
        private BooksService GoogleBookSeachAPIService; 

        public BookSeachService(string ApplicationName, string APIKey)
        {
            GoogleBookSeachAPIService = new BooksService(new BaseClientService.Initializer
            {
                ApplicationName = ApplicationName,
                ApiKey = APIKey,
            });
        }

        //0071807993

        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

        public async Task<Volume> SearchBookISBN(string isbn)
        {

            

            var result = await GoogleBookSeachAPIService.Volumes.List(isbn).ExecuteAsync();
            if (result != null && result.Items!=null)
            {
                var item = result.Items.FirstOrDefault();
                return item;
            }
            return null;
        }
    }
}
