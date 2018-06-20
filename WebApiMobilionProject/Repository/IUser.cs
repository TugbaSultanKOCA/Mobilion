using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiMobilionProject.Data;

namespace WebApiMobilionProject.Repository
{
    public interface IUser
    {
        //Kullanıcı Giriş
        bool ValidateUser(string username, string password);
        //Kullanıcı Kayıt
        bool ValidateRegisterUser(User user);
        //Id ile kayıt getirme
        User GetUserById(int id);
        //Kullanıcı güncelleme
        User Update(User user, int id);
    }
}
