using System;
using System.Collections.Generic;
using System.Text;
using One_Sgp4;
using System.Net;
using System.Diagnostics;

namespace KXStarlinkMobile
{
    class SatData
    {
        internal static void GetTLE()
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://www.celestrak.com/NORAD/elements/supplemental/starlink.txt", "starlink.txt");
                    //statusText.Text = "Pobranie danych skończone.";
                    //return ParserTLE.ParseFile(@"starlink.txt");
                    
                    
                }
                catch (WebException webEx)
                {
                    if (webEx.Status == WebExceptionStatus.ConnectFailure)
                    {
                        //statusText.Text = "Problem z pobraniem pliku.";
                        //return ParserTLE.ParseFile(); ;
                        Debug.WriteLine("Brak polaczenia");
                    }
                    Debug.WriteLine(webEx);
                }
                
            }

            
        }
    }
}
