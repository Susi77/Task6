using ConnectToDB.DataAcces;
using ConnectToDB.Models;
using System;
using System.Collections.Generic;

namespace ConnectToDB
{
    class Program
    {
        static void Main(string[] args)
        {

            Employdal employdal = new Employdal();

            for (int i = 1; i < 10; i++)
            {
                employdal.InsertEmploy

               (new Employ() { ID = i, Name = "Susi" + i, Age = 22, Salary = 500000 });
                

                Console.WriteLine($"ResultText for Employ {i}: {employdal.ResultText}");
            }


            Console.ReadKey();
        }
    }
}
