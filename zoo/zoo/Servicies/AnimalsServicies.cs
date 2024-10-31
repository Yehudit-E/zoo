using Microsoft.AspNetCore.Mvc;
using zoo.Entities;

namespace zoo.Servicies
{
    public class AnimalsServicies
    {
        static List<Animal> dataAnimals = new List<Animal>();
        //private static int count = 0;
        public List<Animal> Get()
        {
            return dataAnimals;
        }
        public Animal GetById(int id)
        {
            return dataAnimals.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Animal a) 
        { 
            dataAnimals.Add(new Animal(a));
            return true;
        }
        public ActionResult<bool> Put(int id,Animal a)
        {
            for (int i = 0; i < dataAnimals.Count; i++)
            {
                if (id == dataAnimals[i].Id)
                {
                    dataAnimals[i] = new Animal(id,a);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataAnimals.Remove(dataAnimals.FirstOrDefault(x => x.Id == id));

        } 
       
    }

}
