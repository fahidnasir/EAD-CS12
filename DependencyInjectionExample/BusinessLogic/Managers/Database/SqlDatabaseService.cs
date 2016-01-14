using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Interfaces;
using Models;

namespace BusinessLogic.Managers
{
    public class SqlDatabaseService<T> : IDatabaseService<T> where T : BaseModel, new()
    {
        public T Get()
        {
            return new T() { CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now };
        }

        public int Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public int Update(T obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
