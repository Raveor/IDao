using System;
using System.Collections.Generic;
using System.Text;

namespace DaoDB
{
    interface IDao<T>
        where T : IStorageObject
    {
        T Get(long id);
        IList<T> GetAll();
        void Save(T obj);
        void Update(T old, T actual);
        void Delete(T obj);
    }
}
