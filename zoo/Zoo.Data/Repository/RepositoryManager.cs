using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Interfaces;

namespace Zoo.Data.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        DataContext dataContext;
        public RepositoryManager(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Save()
        {
            dataContext.SaveChanges();
        }
    }
}
