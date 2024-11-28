using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Show
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int Location { get; set; }//enum 
        public double Price { get; set; }
        public double Duration { get; set; }//מומש, בתוקף
        public int RecommendedAge { get; set; }
        public int GuidId { get; set; }
        public int MaxNumOfViewers { get; set; }


        private static int count = 2;

        public Show() { }


        public Show(Show s)
        {
            Id = count++;
            Name = s.Name;
            Description = s.Description;
            Date = s.Date;
            Time = s.Time;
            Location = s.Location;
            Price = s.Price;
            Duration = s.Duration;
            RecommendedAge = s.RecommendedAge;
            GuidId = s.GuidId;
            MaxNumOfViewers = s.MaxNumOfViewers;

        }
        public Show(int id, Show s)
        {
            Id = id;
            Name = s.Name;
            Description = s.Description;
            Date = s.Date;
            Time = s.Time;
            Location = s.Location;
            Price = s.Price;
            Duration = s.Duration;
            RecommendedAge = s.RecommendedAge;
            GuidId = s.GuidId;
            MaxNumOfViewers = s.MaxNumOfViewers;
        }
    }
}
