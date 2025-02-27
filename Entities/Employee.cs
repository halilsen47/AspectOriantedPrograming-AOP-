using Core.Aspect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public interface IEmployee
    {
        void Add(int id, string firstname, string lastname);
        void update(int id, string firstname, string lastname);
    }
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



        [DefansiveProgramingAspect(pireority = 1)]
        [İnterceptionAspect(pireority = 2)]
        public virtual void Add(int id,string firstname,string lastname)
        {
         
            Console.WriteLine("Added");
        }
        [DefansiveProgramingAspect(pireority = 1)]
        [İnterceptionAspect(pireority = 2)]
        public virtual void update(int id,string firstname,string lastname)
        {
           
            Console.WriteLine("Updated");
        }
    }
}
