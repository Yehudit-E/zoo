using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class ShowsServicies
    {
        static List<Show> dataShows = DataManager.dataManager.dataShows;
        //private static int count = 0;
        public List<Show> Get()
        {
            return dataShows;
        }
        public Show GetById(int id)
        {
            return dataShows.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Show s)
        {
            dataShows.Add(new Show(s));////
            return true;
        }
        public bool update(int id, Show s)
        {
            int index = dataShows.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataShows[index] = new Show(id, s);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataShows.Remove(dataShows.FirstOrDefault(x => x.Id == id));

        }
    }
}
