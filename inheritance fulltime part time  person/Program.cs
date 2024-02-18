using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_fulltime_part_time__person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();   
            Fulltimejob job = new Fulltimejob();
            job.Input();
            job.Output();
            parttime parttime = new parttime();
            parttime.input();
            parttime.output();
            Console.ReadKey();
        }
    }
}
