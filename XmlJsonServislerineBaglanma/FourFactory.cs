using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonServislerineBaglanma
{
    public class FourFactory
    {
        public const string clientID = "YTDDSMXGOP10HPOQXZ2B3WLWRBZXT45YJFH4KWQIC2RBVZIC";
        public const string clientSecret = "ZAAKI34PSZEZ5MKBZDNAIVG5GJ1ZPT2CST2RN5UXY4FV0E01";
        public const string apiUrl = "https://api.foursquare.com/v2/venues/search?";
        public string categoryCode = "4f04af1f2fb6e1c99f3db0bb";
        public int radius = 2000;
        public string latitude = "41.0446062";
        public string longitude = "29.0063537";

        string queryUrl = string.Empty;
        public string jsonString = string.Empty;

        public FourFactory()
        {
            //instance aldığım an bağlansın
            queryUrl += apiUrl;
            queryUrl += "client_id=" + clientID;
            queryUrl += "&client_secret=" + clientSecret;
            queryUrl += "&v=" + $"{DateTime.Now:yyyyMMdd}";
            queryUrl += $"&ll={latitude},{longitude}";
            queryUrl += "&radius=" + radius;
            queryUrl += "&categoryId=" + categoryCode;
            GetVenues(queryUrl);
        }

        private async void GetVenues(string query)
        {
            HttpClient client = new HttpClient();
            try
            {
                jsonString = await client.GetStringAsync(query);
                //jsonString = client.GetStringAsync(query).Result;
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
        private List<Four.Venue> FirmalariDoldur()
        {
            Four sonuc = JsonConvert.DeserializeObject<Four>(jsonString);
            return sonuc.response.venues.ToList();
        }
    }
}
