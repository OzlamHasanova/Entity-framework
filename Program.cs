using ConsoleApp10.Core.Models;
using ConsoleApp10.DataAccess;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp10
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            AppDbContext context = new();
            Employer employer1 = new()
            {
                Id = 1,
                Name = "Ozlem",
                Surname = "Hasanova",
                Salary = 10000,
                
            };
            Employer employer2 = new()
            {
                Id = 2,
                Name = "Humay",
                Surname = "Ehmedova",
                Salary = 4000,
            };
          
            
        }

        //public List<Employer> GetEmployees()
        //{
        //    List<Employer> employees = new List<Employer>();
        //    using (var context = new AppDbContext())
        //    {
        //        var employers = context.Employers.ToList();
        //        foreach (var person in employees) { 
        //            employees.Add(person);
                    
        //        }
        //    }
        //    return employees;
        //    Console.WriteLine(employees);
        //}


        //public async void GetEmployeeById()
        //{
        //    using(var context = new AppDbContext())
        //    {
        //        Employer employer=context.Employers.Find(1);
        //        await context.SaveChangesAsync();
        //        Console.WriteLine(context.Entry(employer).State);
        //        Console.WriteLine(employer);
        //    }
        //}



        public async List<Employer> CreateEmployee()
        {
           
            using(var context=new AppDbContext())
            {
                await context.Employer.AddRangeAsync(employer2)
            }
        }
    } 
}