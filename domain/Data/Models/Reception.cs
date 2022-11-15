using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.Xml;

namespace domain.Data.Models
{
    public class Reception
    {
        public DateTime StartReception { get; set; }

        public DateTime EndReception { get; set; }

        public virtual Doctor Doctor { get; set; }

        public virtual User User { get; set; }

        


    }
}
