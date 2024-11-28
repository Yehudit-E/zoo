using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Entities;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class VisitorsRepository:IRepository<Visitor>
    {
        private readonly DataContext _dataContext;

        public VisitorsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<Visitor> Get()
        {
            return _dataContext.dataVisitors;
        }
        public Visitor GetById(int id)
        {
            return _dataContext.dataVisitors.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Visitor item)
        {
            _dataContext.dataVisitors.Add(new Visitor(item));
            return _dataContext.SaveVisitors();
        }
        public bool Update(int id, Visitor item)
        {
            int index = _dataContext.dataVisitors.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.dataVisitors[index] = new Visitor(id, item);
                return _dataContext.SaveVisitors();
            }
            return false;
        }
        public bool DeleteById(int id)
        {
            if (_dataContext.dataVisitors.Remove(_dataContext.dataVisitors.FirstOrDefault(x => x.Id == id)))
                return _dataContext.SaveVisitors();
            return false;
        }

    }
}
