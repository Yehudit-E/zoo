using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface IEmployeesService
    {
        public List<Employee> Get();
        public Employee? GetById(int id);
        public Employee Add(Employee item);
        public Employee Update(int id, Employee item);
        public bool DeleteById(int id);
    }
}
