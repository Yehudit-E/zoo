using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Service.Services
{
    public class ShowsService: IService<Show>
    {
        readonly IRepository<Show> _iRepository;
        public ShowsService(IRepository<Show> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Show> Get()
        {
            return _iRepository.Get();
        }
        public Show GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public bool Add(Show item)
        {
            return _iRepository.Add(item);
        }
        public bool Update(int id, Show item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }
    }
}
