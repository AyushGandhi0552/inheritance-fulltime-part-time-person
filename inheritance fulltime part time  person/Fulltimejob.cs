using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fulltime_part_time__person
{
    public class Fulltimejob:Person
    {
        public int salary;
        public void Input()
        {
            Console.WriteLine("Please Enter ID:");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your name:");
            Name=Convert.ToString(Console.ReadLine());  
            Console.WriteLine("Please enter salary:");
            salary=Convert.ToInt32(Console.ReadLine());
        }
        public void Output() 
        {
            Console.WriteLine("The id Is:" + Id);
            Console.WriteLine("The name is:" + Name);
            int hra = Convert.ToInt32(salary * 0.5);
            Console.WriteLine("The hra is:" + hra);

            int da = Convert.ToInt32(salary * 0.2);
            Console.WriteLine("The DA is:" + da);

            int totalsalary = salary + hra + da;
            Console.WriteLine("The Totalsalary is:" + totalsalary);

            int tax = Convert.ToInt32(totalsalary * 0.1);
            Console.WriteLine("The tax is:" + tax);

            int netsalary = Convert.ToInt32(totalsalary - tax);
            Console.WriteLine("The netsalary is:" + netsalary);
        }
    }
}
