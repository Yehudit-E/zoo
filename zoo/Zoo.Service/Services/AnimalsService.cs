using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Service.Services
{
    public class AnimalsService : IService<Animal>
    {
        readonly IRepository<Animal> _iRepository;
        public AnimalsService(IRepository<Animal> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Animal> Get()
        {
            return _iRepository.Get();
        }
        public Animal GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public bool Add(Animal item)
        {
            return _iRepository.Add(item);
        }
        public bool Update(int id, Animal item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }

    }
}
