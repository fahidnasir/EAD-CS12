using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Managers;
using Models;

namespace BusinessLogic.Interfaces
{
    public interface IDatabaseService<T>
    {
        /***There is no need to write the same T type in the functions because its already accessable through the class definition.
        * T Get<T>();
        * int Insert<T>(T obj);
        * int Update<T>(T obj);
        * bool Delete<T>(T obj);
        */

        T Get();
        int Insert(T obj);
        int Update(T obj);
        bool Delete(T obj);
        void Save();
    }
}
