using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class EmployeesServicies
    {
        static List<Employee> dataEmployees = new List<Employee>();
        //private static int count = 0;
        public List<Employee> Get()
        {
            return dataEmployees;
        }
        public Employee GetById(int id)
        {
            return dataEmployees.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Employee e)
        {
            dataEmployees.Add(new Employee(e));
            return true;
        }
        public ActionResult<bool> Put(int id, Employee e)
        {
            for (int i = 0; i < dataEmployees.Count; i++)
            {
                if (id == dataEmployees[i].Id)
                {
                    dataEmployees[i] = new Employee(id, e);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataEmployees.Remove(dataEmployees.FirstOrDefault(x => x.Id == id));

        }
    }
}
