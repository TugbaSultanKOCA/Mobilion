using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiMobilionProject.Concrete;
using WebApiMobilionProject.Controllers.UserModel;
using WebApiMobilionProject.Data;
using WebApiMobilionProject.Repository;

namespace WebApiMobilionProject.Controllers
{
  
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUser _user;
        private readonly IDepartment _department;
        public UserController(IUser user,IDepartment department)
        {
            _user = user;
            _department = department;
        }

        //kullanıcı Giriş 
        //Güncelleme 
        //Kayıt
        //
        /// <summary>
        /// Kullanıcı Giriş
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        // GET api/v1/user/{username,password}
        [HttpGet]
        public string Get(string username,string password)
        {
            if (password.Length<6 &&username==null)
            {
                return "Kullanıcı Adı Boş Geçilemez, E Mail En Az 6 Karakter Olmalıdır.";
            }
            var result = _user.ValidateUser(username, password);
            return  result == true ? "Giriş İşlemi başarı ile gerçekleşti" : "Kullanıcı Adı ve Şifre Hatalı" ;
        }
        [HttpPost]
        [ProducesResponseType(typeof(User), 200)]
        public OkObjectResult Post([FromBody]CreateUserDTO user)
        {
            var model = new User
            {
                DepartmentId =  user.DepartmentId,
                Address = user.Address,
                FreeTextContent = user.FreeTextContent,
                FreeTextName = user.FreeTextName,
                IdentificationCode = user.IdentificationCode,
                LastName = user.LastName,
                Name = user.Name,
                Password = user.Password,
                PhoneNumber = user.PhoneNumber,
                Username = user.Username
            };
            var result = _user.ValidateRegisterUser(model);
            return Ok(result == true ? "Kayıt İşlemi Başarılı" : "Kayıt Esnasında bir Hata oluştu.");
        }
        [HttpPut]
        public string Put(int id,[FromBody]User values)
        {
            var entity = _user.Update(values, id);
          return entity != null ? " İşlem başarı ile gerçekleşti" : "Başarısız İşlem";
        }
    
        //Aynı Departmandaki kişileri Listeler
        [HttpGet("{id}")]
        public IEnumerable<User> GetUserList(int id)
        {

            return _department.DepartmanList(id);
        }
    }
}