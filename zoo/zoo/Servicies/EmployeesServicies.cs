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
        public bool IsCorrectTZ(string TZ)
        {
            if (TZ.Length != 9)
                return false;
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                if (TZ[i] < '0' || TZ[i] > '9')
                    return false;
                if (i % 2 == 0)
                    sum += TZ[i] - '0';
                else
                    sum += (TZ[i] - '0') * 2 % 10 + (TZ[i] - '0') * 2 / 10 % 10;
            }
            if (10 - (sum % 10) == TZ[8] - '0')
                return true;
            return false;
        }
        public bool Add(Employee e)
        {
            if(IsCorrectTZ(e.TZ))
            { 
                dataEmployees.Add(new Employee(e));////
                return true;
            }
            return false;
        }
        public bool Update(int id, Employee e)
        {
            int index = dataEmployees.FindIndex(x => x.Id == id);
            if (index != -1&& IsCorrectTZ(e.TZ))
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
