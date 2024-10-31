using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class VisitorsServicies
    {
        static List<Visitor> dataVisitors = new List<Visitor>();
        //private static int count = 0;
        public List<Visitor> Get()
        {
            return dataVisitors;
        }
        public Visitor GetById(int id)
        {
            return dataVisitors.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Visitor v)
        {
            dataVisitors.Add(new Visitor(v));
            return true;
        }
        public ActionResult<bool> Put(int id, Visitor v)
        {
            for (int i = 0; i < dataVisitors.Count; i++)
            {
                if (id == dataVisitors[i].Id)
                {
                    dataVisitors[i] = new Visitor(id, v);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataVisitors.Remove(dataVisitors.FirstOrDefault(x => x.Id == id));

        }
    }
}
