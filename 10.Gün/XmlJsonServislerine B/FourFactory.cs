using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerine_B
{
    public class FourFactory
    {
        public const string clientID = "WB5V3BPXFDQZWPGQHZH04MTHNKVBIXIFYHOFQ2LQN4ZSOUIU";
        public const string clientSecret = "OQNTCPYWTGWIWJACZZOYDCPNLWXGTEGMPYN4HCG4KMYNQTSU";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4d4b7105d754a06374d81259";
        public int radius = 2000;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";

        string quertyUrl = string.Empty;
        public string JsonString = string.Empty;

        public FourFactory()
        {
            quertyUrl = apiUrl;
            quertyUrl += "client_id=" + clientID;
            quertyUrl += "&client_secret=" + clientSecret;
            quertyUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            quertyUrl += $"&ll={latitude},{longitude}";
            quertyUrl += "&radius=" + radius;
            quertyUrl += "&categoryId=" + categoryCode;
            GetVenues(quertyUrl);
        }

        //senkron asenkron olarak çalıştırmak için async ekledik
        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient();
            try
            {
                JsonString = await client.GetStringAsync(query);
                // JsonString = client.GetStringAsync(query).Result;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Four.Venue> Firmalar
        {
            get => FirmalariDoldur();
        }
        private Lazy<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(JsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
