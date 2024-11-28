using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class EmployeesRepository:IRepository<Employee>
    {
        private readonly DataContext _dataContext;

        public EmployeesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Employee> Get()
        {
            return _dataContext.dataEmployees;
        }
        public Employee GetById(int id)
        {
            return _dataContext.dataEmployees.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Employee item)
        {
            _dataContext.dataEmployees.Add(new Employee(item));
            return _dataContext.SaveEmployees();
        }
        public bool Update(int id, Employee item)
        {
            int index = _dataContext.dataEmployees.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataEmployees[index] = new Employee(id, item);
                return _dataContext.SaveAnimals();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataEmployees.Remove(_dataContext.dataEmployees.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveAnimals();
            return false;
        }
    }
}
