using System.Collections.Generic;
namespace Dong_bo_cham_cong.Repositories
{
  interface IBaseRepository<T> where T : class
  {
    IEnumerable<T> Search();
    T Detail(object value);
    bool Insert(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    bool Delete(object key);
  }
}
