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
        public bool Add(Visitor v)
        {
            dataVisitors.Add(new Visitor(v));/////
            return true;
        }
        public bool Update(int id, Visitor v)
        {
            int index = dataVisitors.FindIndex(x => x.Id == id);
            if (index != -1)
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
