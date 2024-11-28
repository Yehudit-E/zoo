using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class AnimalsRepository:IRepository<Animal>
    {
        private readonly DataContext _dataContext;

        public AnimalsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Animal> Get()
        {
            return _dataContext.dataAnimals;
        }
        public Animal GetById(int id)
        {
            return _dataContext.dataAnimals.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Animal item)
        {
            _dataContext.dataAnimals.Add(new Animal(item));
            return _dataContext.SaveAnimals();
        }
        public bool Update(int id, Animal item)
        {
            int index = _dataContext.dataAnimals.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataAnimals[index] = new Animal(id, item);
                return _dataContext.SaveAnimals();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataAnimals.Remove(_dataContext.dataAnimals.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveAnimals();
            return false;
        }
    }
}
