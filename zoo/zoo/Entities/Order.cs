namespace zoo.Entities
{
    public class Order
    {
        public int Id { get; private set; }
        public int CardId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DateOfVisit { get; set; }
        public int VisitorId { get; set; }
        public int Amount { get; set; }
        public double TotalPay { get; set; }
        public int Status { get; set; }//מומש, בתוקף


        private static int count = 1;

        public Order() { }


        public Order(Order o)
        {
            Id = count++;
            CardId = o.CardId;
            OrderDate = o.OrderDate;
            DateOfVisit = o.DateOfVisit;
            VisitorId = count;
            Amount = o.Amount;
            TotalPay = o.TotalPay;
            Status = o.Status;
                
        }
        public Order(int id, Order o)
        {
            Id = id;
            CardId = o.CardId;
            OrderDate = o.OrderDate;
            DateOfVisit = o.DateOfVisit;
            VisitorId = count;
            Amount = o.Amount;
            TotalPay = o.TotalPay;
            Status = o.Status;
        }
    }

}
