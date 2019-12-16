using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeteriiSeteri
{
    class Person
    {

        private string _firstName = "Sanel";
        private string _lastName = "Ljuskovic";
        private int _age = 30;

        public string FirstName { 
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }



        public string SayAge()
        {
            return $"Moja starost je {Age}";

        }

    }

    class Student : Person
    {

    }


    class Program

    {
        static void Main(string[] args)
        {
            Student st = new Student();
            Console.WriteLine("Ime: {0}\nPrezime: {1}\nStarost: {2}\n\n", st.FirstName, st.LastName, st.Age);
            st.FirstName = "SANEL";
            st.LastName = "LJUSKOVIC";
            st.Age = 40;
            Console.WriteLine("Ime: {0}\nPrezime: {1}\nStarost: {2}\n\n", st.FirstName, st.LastName, st.Age);
            Console.WriteLine(st.SayAge());
            Console.ReadKey();


        }
    }
}