using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClientProject.ViewModels
{
    public class FormSubmitViewModel
    {
            [Required]
            public string name { get; set; }

            [Required]
           
            public double contactNumber { get; set; }
            
            [EmailAddress]
            public string emailAddress { get; set; }

            [Required]
            public string purpose { get; set; }

            public FormSubmitViewModel(int id,string name, double contactNumber, string emailAddress, string purpose)
            {
                this.name = name;
                this.contactNumber = contactNumber;
                this.emailAddress = emailAddress;
                this.purpose = purpose;
            }

            public FormSubmitViewModel()
            {

            }
        }
}
