using ASPNET5_DIApp.Models;
using System.Collections.Generic;

namespace ASPNET5_DIApp.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get();
    }
    public class EmployeeInfoService : IService<EmployeeInfo>
    {
        DataAccess ds;
        public EmployeeInfoService()
        {
            ds = new DataAccess (); 
        }
        public IEnumerable<EmployeeInfo> Get()
        {
            return ds.Get();
        }
    }
}
