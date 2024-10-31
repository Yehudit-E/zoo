using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class ShowsServicies
    {
        static List<Show> dataShows = new List<Show>();
        //private static int count = 0;
        public List<Show> Get()
        {
            return dataShows;
        }
        public Show GetById(int id)
        {
            return dataShows.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Show s)
        {
            dataShows.Add(new Show(s));
            return true;
        }
        public ActionResult<bool> Put(int id, Show s)
        {
            for (int i = 0; i < dataShows.Count; i++)
            {
                if (id == dataShows[i].Id)
                {
                    dataShows[i] = new Show(id, s);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataShows.Remove(dataShows.FirstOrDefault(x => x.Id == id));

        }
    }
}
