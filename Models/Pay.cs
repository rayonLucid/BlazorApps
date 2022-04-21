using System;
using System.ComponentModel.DataAnnotations;

namespace Club_Portal.Models
{
    public class Pay
    {
        [Key]
        public string PaymentId { get; set; }
        public string PaymentRef { get; set; }
        public string NARRATION { get; set; }
        public string UserID { get; set; }
        public string Note { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string  Cardnumber { get; set; }
      public string   Cvv { get; set; }
      public string   MonthOfExpiration { get; set; }
      public string   YearOfExpiration { get; set; }
    }
}