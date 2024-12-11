using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Entities
{
    public class Ticket
    {
        [Key]
        public int Id { get; private set; }
        public string Type { get; set; }//enum
        public double Price  { get; set; }


    

        public Ticket() { }


        public Ticket(Ticket t)
        {
            Id = t.Id;
            Type=t.Type; 
            Price = t.Price;

        }
     
    }
}
