using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMobilionProject.Data;

namespace WebApiMobilionProject.Repository
{
    public interface IDepartment
    {
        //Aynı Departmandaki kişileri Listeleme
        IList<User> DepartmanList(int id);
        //Departman Id ye göre kişi detaylarını Getirme
        User GetByDepartmentId(int id);
    }
}
