using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVienWF.Model
{
    public interface IModelCRUD<T>
    {
         List<T> GetAll();
        bool Delete(string Id); 
        bool Insert(T item);
        bool Update(T item);
        T GetById(string Id);
    }
}
