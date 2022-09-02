using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Email 
    {
        public int Id { get; set; } 
        public string FromEmailAddress { get; set; }
        public string ToEmailAddress { get; set; }
        public string CCEmailAdresses { get; set; }
        public string Subject { get; set; }
        public string Importance { get; set; }
        public string EmailContent { get; set; }
    }
}
