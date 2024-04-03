using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carpool.Domain.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageContent { get; set; } = string.Empty;
        public DateTime SendingDate { get; set; }
        public DateTime ReceiptDate { get; set; }

        public int SenderUserID { get; set; }
        public User UserSender { get; set; }
        public int ReceiverUserID { get; set; }
        public User UserReceiver { get; set; }
    }
}