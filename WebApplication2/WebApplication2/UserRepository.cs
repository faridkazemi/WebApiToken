using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Entities;

namespace WebApplication2
{
    public class UserRepository:IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<TokenTest> FindUser(string userName, string password)
        {
            using (var db = new MyDatabase())
            {
                try
                {
                    return new TokenTest()
                    {
                        Password = "abc",
                        UserName = "Farid",
                        ConfirmPassword = "abc"
                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
              
            }
        }

    }
}