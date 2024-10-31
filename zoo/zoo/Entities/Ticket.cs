namespace zoo.Entities
{
    public class Ticket
    {
        public int Id { get; private set; }
        public string Type { get; set; }//enum
        public double Price  { get; set; }


        private static int count = 1;

        public Ticket() { }


        public Ticket(Ticket t)
        {
            Id = count++;
            Type=t.Type; 
            Price = t.Price;

        }
        public Ticket(int id, Ticket t)
        {
            Id = id;
            Type = t.Type;
            Price = t.Price;
        }
    }
}
