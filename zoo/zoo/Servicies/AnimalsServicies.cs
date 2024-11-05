using Microsoft.AspNetCore.Mvc;
using zoo.DTO;
using zoo.Entities;

namespace zoo.Servicies
{
    public class AnimalsServicies
    {
        static List<Animal> dataAnimals = DataManager.dataManager.dataAnimals;
        //private static int count = 0;
        public List<Animal> Get()
        {
            return dataAnimals;
        }
        public Animal GetById(int id)
        {
            return dataAnimals.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Animal a) 
        { 
            dataAnimals.Add(new Animal(a));///תקינות
            return true;
        }
        public bool Update(int id,Animal a)
        {
            int index = dataAnimals.FindIndex(x => x.Id == id);
            if (index!=-1)
            {
                dataAnimals[index] = new Animal(id, a);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataAnimals.Remove(dataAnimals.FirstOrDefault(x => x.Id == id));

        } 
       
    }

}
