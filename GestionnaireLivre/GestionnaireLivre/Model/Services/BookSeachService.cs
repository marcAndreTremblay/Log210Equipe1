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

namespace GestionnaireLivre.Model.Services
{
    public class  BookSeachService
    {
        private BooksService GoogleBookSeachAPIService; 

        public BookSeachService(string ApplicationName, string APIKey)
        {
            GoogleBookSeachAPIService = new BooksService(new BaseClientService.Initializer
            {
                ApplicationName = "gestionnaireBD",
                ApiKey = "AIzaSyAKEJaaZvVIMzPCOxqScfyP5UKcrtpjS4c",
            });
        }

        //0071807993
                


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
