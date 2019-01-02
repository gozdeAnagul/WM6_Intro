using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlJsonServislerine_B
{
    public class DovizFactory
    {
        private static List<Doviz> _dovizler;
        public static List<Doviz> Dovizler
        {
            //dovizlerin instance sini aldım yani örnek aldım yani her seferinde listi aldım
            get
            {
                _dovizler = new List<Doviz>();
                XElement xElement;
                try
                {
                    xElement = XElement.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                }
                catch (Exception ex)
                {
                    throw ex;
                    //Console.WriteLine(ex.Message); Aynı mesajı verir.
                }

                IEnumerable<XElement> currencies = from k in xElement.Elements()
                                 where k.Element("CurrencyName") != null &&
                                       k.Attribute("Kod").Value != "XDR"
                                 select k;
                //Yukarıdakiyle aynı sorgu
                var kurlar = xElement.Elements().Where(k => k.Element("CurrencyName") != null &&
                                   k.Attribute("Kod").Value != "XDR").Select(k => k);

                foreach (XElement element in kurlar)
                {
                    //anonin nesne
                    _dovizler.Add(new Doviz()
                    {
                        Ad = element.Element("Isim").Value,
                        Kod=element.Attribute("Kod").Value,
                        Birim=Convert.ToInt32(element.Element("Unit").Value),
                        //bizim para birimimizi virgülle ayrdığımız için dönüşüm yapmamız gerekirdi. o yuzden noktayı virgüle vericez.
                        Alis = decimal.Parse(element.Element("ForexBuying").Value.Replace('.', ',')),
                        Satis = decimal.Parse(element.Element("ForexSelling").Value.Replace('.', ','))
                    });                 
                }
                return _dovizler;
            }
        }
    }
}
