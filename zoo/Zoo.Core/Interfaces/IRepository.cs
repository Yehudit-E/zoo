using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Core.Interfaces
{
    public interface IRepository<T>
    {
        public List<T> Get();
        public T GetById(int id);
        public bool Add(T item);
        public bool Update(int id, T item);
        public bool DeleteById(int id);

    }
}
