using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GCPAPi.Models
{
    public class Security
    {
        public int Id { get; set; }

         
        public string SecurityId { get; set; }

         
        public ProductType ProductType { get; set; }

        
        public string DealID { get; set; }

         
        public string Issuer { get; set; }

       
        public string Currency { get; set; }
    }


    public enum ProductType
    {
         
        EuroBond,
        MTN,
        ECP,
        MBS,
        Loan,
        ABS
    }
}
