using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class EmployeesServicies
    {

        static List<Employee> dataEmployees = DataManager.dataManager.dataEmployees;
        //private static int count = 0;
        public List<Employee> Get()
        {
            return dataEmployees;
        }
        public Employee GetById(int id)
        {
            return dataEmployees.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Employee e)
        {
            dataEmployees.Add(new Employee(e));////
            return true;
        }
        public bool Update(int id, Employee e)
        {
            int index = dataEmployees.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataEmployees[index] = new Employee(id, e);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataEmployees.Remove(dataEmployees.FirstOrDefault(x => x.Id == id));

        }
    }
}
