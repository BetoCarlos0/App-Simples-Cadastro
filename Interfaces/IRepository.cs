using System.Collections.Generic;

namespace App_Simples_Cadastro
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnId(int id);        
        void Insert(T entity);        
        void Delete(int id);        
        void Update(int id, T entity);
        int NextId();
    }
}