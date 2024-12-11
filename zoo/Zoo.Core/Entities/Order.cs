using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CardId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int VisitorId { get; set; }
        public int Amount { get; set; }
        public double TotalPay { get; set; }
        public int Status { get; set; }//מומש, בתוקף



        public Order() { }


        public Order(Order o)
        {
            Id = o.Id;
            CardId = o.CardId;
            OrderDate = o.OrderDate;
            DateOfVisit = o.DateOfVisit;
            VisitorId = o.VisitorId;
            Amount = o.Amount;
            TotalPay = o.TotalPay;
            Status = o.Status;
                
        }
       
    }

}
