using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryIt.Interfaces;

namespace QueryIt.Domain
{
    public class Employee:Person,IEntity
    {
        public int Id { get; set; }
        public virtual void DoWork()
        {
            Console.WriteLine("Doing real work");
        }

        public bool IsValid()
        {
            //validate employee object or use data annotations
            return true;
        }
    }
}

