using Connected.DataAcces;
using Connected.Models;
using System;
using System.Collections.Generic;

namespace Connected
{
    class Program
    {
        static void Main(string[] args)
        {

            EmployDAL employDAL = new EmployDAL();

            for (int i=1;i<10;++i )
            {
                employDAL.InsertEmploy
                    (new Employ
                    {ID=1,Name ="Susi"+i,Age=21,Salary=500000 });
                Console.WriteLine($"ResultText for Employ {i}: {employDAL.ResultText}");
            }

            Console.ReadKey();
        }
    }
}
