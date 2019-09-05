using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApp.Models
{
    public class InsuranceQuote
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public string dateOfBirth { get; set; }
        public int carYear { get; set; }
        public string carMake { get; set; }
        public string carModel { get; set; }
        public int tickets { get; set; }
        public bool coverage { get; set; }
        public bool dui { get; set; }
        public bool age1 { get; set; }
        public bool age2 { get; set; }
        public bool age3 { get; set; }
        public bool carAge1 { get; set; }
        public bool carAge2 { get; set; }
        public int quoteTotal { get; set; }


    }
}