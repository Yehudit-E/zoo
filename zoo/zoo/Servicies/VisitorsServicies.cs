using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class VisitorsServicies
    {
        static List<Visitor> dataVisitors = DataManager.dataManager.dataVisitors;
        //private static int count = 0;
        public List<Visitor> Get()
        {
            return dataVisitors;
        }
        public Visitor GetById(int id)
        {
            return dataVisitors.FirstOrDefault(x => x.Id == id);
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
        public bool Add(Visitor v)
        {
            if(IsCorrectTZ(v.TZ))
            { 
                dataVisitors.Add(new Visitor(v));/////
                return true;
            }
            return false;
        }
        public bool Update(int id, Visitor v)
        {
            int index = dataVisitors.FindIndex(x => x.Id == id);
            if (index != -1 && IsCorrectTZ(v.TZ))
            {
                dataVisitors[index] = new Visitor(id, v);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataVisitors.Remove(dataVisitors.FirstOrDefault(x => x.Id == id));

        }
    }
}
