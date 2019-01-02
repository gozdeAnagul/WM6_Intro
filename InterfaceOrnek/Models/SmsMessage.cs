using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsMessage:MessageBase
    {
        private string _body, _sender;
        public override string Body
        {
            get=> _body;
            set
            {
                if (value.Length > 160)
                    throw new Exception("160 dan büyük olamaz");
                _body=value;
            }
        }
        public override string Sender
        {
            get => _sender;
            set
            {
                if (value.Length > 12)
                    throw new Exception("12 den büyük olamaz");
                _sender = value;
            }
        }
    }
}
