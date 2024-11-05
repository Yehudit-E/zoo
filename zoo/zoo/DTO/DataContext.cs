using zoo.Entities;

namespace zoo.DTO
{
    public class DataContext
    {
        public List<Animal> dataAnimals = new List<Animal>();
        public List<Employee> dataEmployees = new List<Employee>();
        public List<Order> dataOrders = new List<Order>();
        public List<Show> dataShows = new List<Show>();
        public List<Ticket> dataTickets = new List<Ticket>();
        public List<Visitor> dataVisitors = new List<Visitor>();
    }
}
