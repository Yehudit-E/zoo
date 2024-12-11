using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;
using Zoo.Core.Interfaces.IServices;

namespace Zoo.Service.Services
{
    public class ShowsService: IShowsService
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
        public Show? GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public Show Add(Show item)
        {
            return _iRepository.Add(item);
        }
        public Show Update(int id, Show item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }
    }
}
