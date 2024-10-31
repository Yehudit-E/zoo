namespace zoo.Entities
{
    public class Animal
    {
        public int Id { get;private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public DateTime FeedingTime { get; set; }

        private static int count = 1;

        public Animal() {}


        public Animal(Animal a)
        {
            Id = count++;
            Name = a.Name;
            Category = a.Category;
            Age = a.Age;
            Species = a.Species;
            Weight = a.Weight;
            Height = a.Height;
            FeedingTime = a.FeedingTime;
        }
        public Animal(int id,Animal a)
        {
            Id = id;
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
