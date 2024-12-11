using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;

namespace Zoo.Core.Interfaces.IServices
{
    public interface IVisitorsService
    {
        public List<Visitor> Get();
        public Visitor? GetById(int id);
        public Visitor Add(Visitor item);
        public Visitor Update(int id, Visitor item);
        public bool DeleteById(int id);
    }
}
