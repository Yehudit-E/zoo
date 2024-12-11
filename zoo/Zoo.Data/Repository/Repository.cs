using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zoo.Core.Interfaces;


namespace Zoo.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly IRepositoryManager repositoryManager;
        public Repository(DataContext dataContex, IRepositoryManager repositoryManager)
        {
            _dbSet = dataContex.Set<T>();
            this.repositoryManager = repositoryManager;
        }
        public List<T> Get()
        {
            return _dbSet.ToList();
        }
        public T? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T Add(T t)
        {
            _dbSet.Add(t);
            repositoryManager.Save();
            return t;
        }

        public T Update(int id, T uptadeEntity)
        {
            var existingEntity = _dbSet.Find(id);
            if (existingEntity == null)
            {
                return null;
            }

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                                      .Where(prop => prop.Name != "Id");

            foreach (var property in properties)
            {
                var updatedValue = property.GetValue(uptadeEntity);
                if (updatedValue != null)
                {
                    property.SetValue(existingEntity, updatedValue);
                }
            }
            repositoryManager.Save();
            return existingEntity;
        }
        public bool DeleteById(int id)
        {
            T find = _dbSet.Find(id);
            if (find != null)
            {
                _dbSet.Remove(find);
                repositoryManager.Save();
                return true;
            }
            return false;
        }




    }
}
