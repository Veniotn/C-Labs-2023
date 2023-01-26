// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

//oop interface student teacher portal

namespace SchoolTracker
{


    class Program
    {

        static void Main(string[] args)
        {
            // PayRoll payRoll = new PayRoll();
            // payRoll.PayAll();
            
            List<IGraduate> IGraduate = new List<IGraduate>();
            
            
            Student student1 = new Student();
            student1.Name = "Nick";
            
            Student student2 = new Student();
            student2.Name = "Yousef";
            
            IGraduate.Add(student1);
            IGraduate.Add(student2);

            Registrar registrar1 = new Registrar(IGraduate);

            registrar1.GraduateAll();
        }
    }
}