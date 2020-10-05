using One_Sgp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;


namespace KXStarlinkMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TlePage : ContentPage
    {
        List<Tle> tlelist;

        public TlePage()
        {
            InitializeComponent();
        }

        private void TleButton_Clicked(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://www.celestrak.com/NORAD/elements/supplemental/starlink.txt", "starlink.txt");
                    TleLabel.Text = "Pobranie danych skończone.";
                    //return ParserTLE.ParseFile(@"starlink.txt");


                }
                catch (WebException webEx)
                {
                    if (webEx.Status == WebExceptionStatus.ConnectFailure)
                    {
                        TleLabel.Text = "Problem z pobraniem pliku.";
                        //return ParserTLE.ParseFile(); ;
                        //Debug.WriteLine("Brak polaczenia");
                    }
                    TleLabel.Text = webEx.Message;
                }
                
            }
        }
    }
}