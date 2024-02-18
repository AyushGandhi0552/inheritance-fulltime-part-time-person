using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fulltime_part_time__person
{
    public class parttime:Person
    {
        public int hours;
        public int payrate;
        public int salary;
        public void input()
        {
            Console.WriteLine("Please Enter your Id:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter Your name:");
            Name= Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please Enter Total Hours:");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Payrate");
            payrate = Convert.ToInt32(Console.ReadLine());
            
        }
        public void output()
        {
            Console.WriteLine(Id);
            Console.WriteLine(Name);
            Console.WriteLine(hours); 
            Console.WriteLine(payrate);
            Console.WriteLine(hours*payrate);
        }
    }
}
