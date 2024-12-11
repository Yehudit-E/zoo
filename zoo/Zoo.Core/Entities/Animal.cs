using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Animal
    {
        [Key]
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime FeedingTime { get; set; }

        public Animal() {}


        public Animal(Animal a)
        {
            
            Id =a.Id;
            Name = a.Name;
            Category = a.Category;
            Age = a.Age;
            Species = a.Species;
            Weight = a.Weight;
            Height = a.Height;
            FeedingTime = a.FeedingTime;
        }
        
    }
}
