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
    public class AnimalsService : IAnimalsService
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
        public Animal? GetById(int id)
        {
            return _iRepository.GetById(id);
        }

        public Animal Add(Animal item)
        {
            return _iRepository.Add(item);
        }
        public Animal Update(int id, Animal item)
        {
            return _iRepository.Update(id, item);
        }
        public bool DeleteById(int id)
        {
            return _iRepository.DeleteById(id);
        }

    }
}
