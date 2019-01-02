using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public abstract class MessageBase
    {

        protected MessageBase()
        {
            this.MessageDate = DateTime.Now;
        }
        public virtual string Sender { get; set; }
        public virtual string Body { get; set; }


        //mesaj gönderimi yaparken sadece içeriden set etmek için bir yöntem;
        //sebebi mesaj gönderdiğimiz zaman tarih lazım olabilir
        //dşarıdan set yok sadece program içinde set var
        public DateTime MessageDate { get; private set; }
    }
}
