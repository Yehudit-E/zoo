using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class AnimalsServicies
    {
        private readonly IDataContex _dataAnimals;
        public AnimalsServicies(IDataContex dataAnimals)
        {
            _dataAnimals = dataAnimals;
        }
        public List<Animal> Get()
        {
           
            return _dataAnimals.LoadData();
        }
        public Animal GetById(int id)
        {
            return _dataAnimals.LoadData().FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Animal a) 
        {
            List<Animal> data = _dataAnimals.LoadData();
            data .Add(new Animal(a));
            _dataAnimals.SaveData(data);
            return true;
        }
        public bool Update(int id,Animal a)
        {
            List<Animal> data = _dataAnimals.LoadData();
            int index = data.FindIndex(x => x.Id == id);
            if (index!=-1)
            {
                data[index] = new Animal(id, a);
                _dataAnimals.SaveData(data);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            List<Animal> data = _dataAnimals.LoadData();
            bool res=data.Remove(data.FirstOrDefault(x => x.Id == id));
            _dataAnimals.SaveData(data);
            return res;
        } 
       
    }

}
