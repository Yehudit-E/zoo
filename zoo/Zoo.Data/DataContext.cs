using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Animal> dbAnimals { get; set; }
        public DbSet<Employee> dbEmployees { get; set; }
        public DbSet<Order> dbOrders { get; set; }
        public DbSet<Show> dbShows { get; set; }
        public DbSet<Ticket> dbTickets { get; set; }
        public DbSet<Visitor> dbVisitors { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.LogTo(mesege => Console.Write(mesege));

        }
      
    }
}
