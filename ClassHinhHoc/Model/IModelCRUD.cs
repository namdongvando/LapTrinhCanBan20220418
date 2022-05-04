
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHinhHoc.Model
{
  public interface IModelCRUD<T>
    {
        public IList<T> GetAll();
        bool Delete(string id);
        T GetById(string id);
        IList<T> GetByName(string id);
        bool Insert(T item);
        bool Update(T item);
    }
}
