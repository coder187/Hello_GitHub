﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_GitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Git Hub");
            Console.WriteLine(Environment.MachineName.ToLower());
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine("this line added in fork!");
            Console.WriteLine("this line added in fork1!");
            Console.WriteLine("this line added in fork1!");
            employee e = GetEmp(7, Emps());
            Console.WriteLine(e.email);
            Console.WriteLine("this line added in fork1!");
            Console.WriteLine("this line added in fork2!");

            Console.ReadKey();
        }

        public static employee GetEmp(int EmpId, List<employee> e)
        {
            employee ew = new employee();
            foreach (employee emp in e)
            {
                if (emp.id == EmpId)
                {
                    ew = emp;
                    break;
                }
            }
            return ew;
        }

        public static List<employee> Emps()
        {

            List<employee> es = new List<employee>();

            es.Add(new employee { id = 1, email = "jon@ksd.ie", fname = "Jon", sname = "kelly", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 2, email = "mick@ksd.ie", fname = "Michael", sname = "", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 3, email = "jimh@ksd.ie", fname = "James", sname = "", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 4, email = "salh@ksd.ie", fname = "James", sname = "", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 5, email = "lilh@ksd.ie", fname = "James", sname = "", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 6, email = "sadh@ksd.ie", fname = "James", sname = "", manager = 1, start = DateTime.Now });
            es.Add(new employee { id = 7, email = "okih@ksd.ie", fname = "James", sname = "", manager = 1, start = DateTime.Now });


            return es;
        }

    }
    class employee
    {
        public int id { get; set; }
        public string fname { get; set; }
        public string sname { get; set; }
        public int manager { get; set; }
        public string email { get; set; }
        public DateTime start { get; set; }
    }

    class vehcile
    {
        public int id { get; set; }
        public string reg { get; set; }
        
    }

}

