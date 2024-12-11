using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface IAnimalsService
    {
        public List<Animal> Get();
        public Animal? GetById(int id);
        public Animal Add(Animal item);
        public Animal Update(int id, Animal item);
        public bool DeleteById(int id);
    }
}
