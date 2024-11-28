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
    public class DataContext
    {
        public List<Animal> dataAnimals;
        public List<Employee> dataEmployees;
        public List<Order> dataOrders;
        public List<Show> dataShows;
        public List<Ticket> dataTickets;
        public List<Visitor> dataVisitors;

        public DataContext()
        {
            LoadAnimals();
            LoadEmployees();
            LoadOrders();
            LoadShows();
            LoadTickets();
            LoadVisitors();
        }
        private void LoadAnimals()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataAnimals.json");
            string jsonString = File.ReadAllText(path);
            dataAnimals = JsonSerializer.Deserialize<List<Animal>>(jsonString);
        }
        private void LoadEmployees()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataEmployees.json");
            string jsonString = File.ReadAllText(path);
            dataEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        }
        private void LoadOrders()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataOrders.json");
            string jsonString = File.ReadAllText(path);
            dataOrders = JsonSerializer.Deserialize<List<Order>>(jsonString);
        }
        private void LoadShows()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataShows.json");
            string jsonString = File.ReadAllText(path);
            dataShows = JsonSerializer.Deserialize<List<Show>>(jsonString);
        }
        private void LoadTickets()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataTickets.json");
            string jsonString = File.ReadAllText(path);
            dataTickets = JsonSerializer.Deserialize<List<Ticket>>(jsonString);
        }
        private void LoadVisitors()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "DataVisitors.json");
            string jsonString = File.ReadAllText(path);
            dataVisitors = JsonSerializer.Deserialize<List<Visitor>>(jsonString);
        }
        public bool SaveAnimals()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataAnimals.json");
                string jsonString = JsonSerializer.Serialize<List<Animal>>(dataAnimals);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveEmployees()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataEmployees.json");
                string jsonString = JsonSerializer.Serialize<List<Employee>>(dataEmployees);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveOrders()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataOrders.json");
                string jsonString = JsonSerializer.Serialize<List<Order>>(dataOrders);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveShows()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataShows.json");
                string jsonString = JsonSerializer.Serialize<List<Show>>(dataShows);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveTickets()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataTickets.json");
                string jsonString = JsonSerializer.Serialize<List<Ticket>>(dataTickets);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SaveVisitors()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "DataVisitors.json");
                string jsonString = JsonSerializer.Serialize<List<Visitor>>(dataVisitors);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
