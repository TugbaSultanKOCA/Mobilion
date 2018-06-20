using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMobilionProject.Data;
using WebApiMobilionProject.Repository;

namespace WebApiMobilionProject.Concrete
{
    public class UserConcrete:IUser
    {
        //Dependency Injection
        private ApiContext _context;
        public UserConcrete(ApiContext context)
        {
            _context = context;
        }


        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(x => x.UserId == id);
        }
        //Kullanıcı Güncelleme
        public User Update(User user,int id)
        {
            var oldItem = _context.User.FirstOrDefault(x => x.UserId == id);
            oldItem.Address = user.Address;
            oldItem.DepartmentId = user.DepartmentId;
            oldItem.Department = user.Department;
            oldItem.FreeTextContent = user.FreeTextContent;
            oldItem.FreeTextName = user.FreeTextName;
            oldItem.IdentificationCode = user.IdentificationCode;
            oldItem.LastName = user.LastName;
            oldItem.Name = user.Name;
            oldItem.Password = user.Password;
            oldItem.PhoneNumber = user.PhoneNumber;
            oldItem.UserId = user.UserId;
            oldItem.Username = user.Username;
            
            _context.Entry(oldItem).State = EntityState.Modified;
            _context.SaveChanges();

            return user;
        }
        //Kullanıcı Kayıt
        public bool ValidateRegisterUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            if (user.UserId != 0)
            {
                return true;
            }
            return false;

        }
        //Kullanıcı Girişi
        public bool ValidateUser(string username, string password)
        {
            var entity = _context.User.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (entity!=null)
            {
                return true;
            }
            return false;
        }
    }
}
