using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public virtual void Add(int id,string firstname,string lastname)
        {
            //Console.WriteLine("Method Body Start!");
            //Console.WriteLine($"\t{"id",-15} : {id}");
            //Console.WriteLine($"\t{"FirstName",-15} : {firstname}");
            //Console.WriteLine($"\t{"LastName",-15} : {lastname}");
            //Console.WriteLine("Method body End!");

            Console.WriteLine("Added");
        }
    }
}
