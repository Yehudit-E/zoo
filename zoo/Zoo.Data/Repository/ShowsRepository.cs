using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class ShowsRepository : IRepository<Show>
    {
        private readonly DataContext _dataContext;

        public ShowsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Show> Get()
        {
            return _dataContext.dataShows;
        }
        public Show GetById(int id)
        {
            return _dataContext.dataShows.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Show item)
        {
            _dataContext.dataShows.Add(new Show(item));
            return _dataContext.SaveShows();
        }
        public bool Update(int id, Show item)
        {
            int index = _dataContext.dataShows.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataShows[index] = new Show(id, item);
                return _dataContext.SaveShows();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataShows.Remove(_dataContext.dataShows.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveShows();
            return false;
        }

    }
}
