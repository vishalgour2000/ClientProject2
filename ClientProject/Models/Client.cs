using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientProject.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public double contactNumber { get; set; }
        public string emailAddress { get; set; }
        public string purpose { get; set; }

        public Client()
        {}
        public Client(int id,string name, double contactNumber, string emailAddress, string purpose)
        {
            this.id = id;
            this.name = name;
            this.contactNumber = contactNumber;
            this.emailAddress = emailAddress;
            this.purpose = purpose;
        }

       
    }
}
