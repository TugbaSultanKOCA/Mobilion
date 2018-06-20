using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiMobilionProject.Data;
using WebApiMobilionProject.Repository;

namespace WebApiMobilionProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Department")]
    public class DepartmentController : Controller
    {
        IDepartment _department;
        public DepartmentController( IDepartment department)
        {
            _department = department;
        }
        [HttpGet("{DepartmanId}")]
      //  Kişi Detaylarını Listeler
        public User Get(int DepartmanId)
        {
            return _department.GetByDepartmentId(DepartmanId);
        }
    }
}