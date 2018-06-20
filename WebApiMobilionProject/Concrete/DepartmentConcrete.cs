using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMobilionProject.Data;
using WebApiMobilionProject.Repository;

namespace WebApiMobilionProject.Concrete
{
    public class DepartmentConcrete:IDepartment
    {
        //Dependency Injection
        private ApiContext _context;
        public DepartmentConcrete(ApiContext context)
        {
            _context = context;
        }
        //Aynı Departmana ait kullanıcı listesi
        public IList<User> DepartmanList(int id)
        {
            return  _context.Set<User>().Where(x=>x.DepartmentId==id).ToList();
        }
        //Departman Id göre detay
        public User GetByDepartmentId(int id)
        {
            return _context.User.FirstOrDefault(x => x.DepartmentId == id);
        }
    }
}
