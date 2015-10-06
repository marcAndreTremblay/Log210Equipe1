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
using GestionnaireLivre.Model.Services;

using System.Net;
using System.IO;
using System.Drawing;

namespace GestionnaireLivre.Forms.UtilityUC
{
    public partial class BookPreviewUC : UserControl
    {
        public BookPreviewUC(Volume book)
        {
            InitializeComponent();


            if (book.VolumeInfo.Authors != null)
            {
                labelAuthor.Text = book.VolumeInfo.Authors.FirstOrDefault();
            }
            if (book.VolumeInfo.Categories != null)
            {
                labelCategories.Text = book.VolumeInfo.Categories.FirstOrDefault();
            }
           
            labelTitle.Text = book.VolumeInfo.Title;
            labelPublisher.Text = book.VolumeInfo.Publisher;
            labelLanguage.Text = book.VolumeInfo.Language;
            labelID.Text = book.Id;
            richTBDescription.Text = book.VolumeInfo.Description;
           
           
            Volume.VolumeInfoData.ImageLinksData links = book.VolumeInfo.ImageLinks;
            if (links != null)
            {
                Image small = GetImageFromUrl(links.Small);
                Image smallThumbnail = GetImageFromUrl(links.SmallThumbnail);

                if (small != null)
                {
                    pictureBBookCover.Image = small;
                }
                if(smallThumbnail != null)
                {
                    pictureBBookCover.Image = smallThumbnail;
                }
            }
            else
            {
                pictureBBookCover.Image = null;
            }
        }


        //Note(Marc) : Maybe create a IOService with that kind of method
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

    }
}
