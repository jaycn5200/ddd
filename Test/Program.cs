using System;
using Test.Core.Entity;
using Test.EFCore;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext myDbContext = new MyDbContext();
            RoleEntity roleEntity = new RoleEntity();
            roleEntity.Name = "管理员";
            myDbContext.Roles.Add(roleEntity);
            myDbContext.SaveChanges();
            Console.WriteLine("ok");
            Console.ReadKey();
        }
    }
}
