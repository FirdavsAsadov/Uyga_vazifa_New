using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_Task5
{
    internal class Email
    {
        public string receiverAddress { get; set;}
        public string senderAddress { get; set;}
        public string subject { get; set;}
        public string body { get; set;}
        public DateTime date { get; set;}
        public bool isClassified { get; set;}
    }
}
