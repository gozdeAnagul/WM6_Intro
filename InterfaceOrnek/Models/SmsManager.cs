using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Models
{
    public class SmsManager:INotificator
    {
        public MessageStates MessageState { get; set; }

        public void Send(MessageBase message)
        {
            MessageState = MessageStates.Pending;
            try
            {
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
