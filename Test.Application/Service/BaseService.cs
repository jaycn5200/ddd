using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Entity;
using Test.EFCore;

namespace Test.Application.Service
{
   public class BaseService<T>where T:BaseEntity
   {
       private readonly MyDbContext _myDbContext;

       public BaseService(MyDbContext myDbContext)
       {
           _myDbContext = myDbContext;
       }
        /// <summary>
        /// 获取所有的条数
        /// </summary>
        /// <returns></returns>
       public List<T> GetAll()
       {
           return _myDbContext.Set<T>().Where(t => t.IsDelete == false).ToList();
       }
        /// <summary>
        /// 软删除
        /// </summary>
        /// <param name="id"></param>
       public async Task MarkIsDelete(int id)
       {
           var firstOrDefault = _myDbContext.Set<T>().Where(t => t.Id == id).FirstOrDefault();
           if (firstOrDefault != null) firstOrDefault.IsDelete = true;
          await _myDbContext.SaveChangesAsync();

       }
        /// <summary>
        /// 根据Id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public T GetById(int id)
       {
           var firstOrDefault = _myDbContext.Set<T>().Where(t => t.Id == id).FirstOrDefault();
           return firstOrDefault;
       }
    }
}
