using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface IShowsService
    {
        public List<Show> Get();
        public Show? GetById(int id);
        public Show Add(Show item);
        public Show Update(int id, Show item);
        public bool DeleteById(int id);
    }
}
