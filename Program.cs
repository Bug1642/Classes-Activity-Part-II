using System;
namespace Exercise {
    public class Person {
        private  string firstName;
        private string lastName;

            public string FirstName{
                get{return firstName;}
                set{firstName = value;}
            }
            public  string LastName{
                get{return lastName;}
                set{lastName = value;}
            }
            public string FullName{
                get{return firstName +" "+ lastName;}
            }
         public Person()
        {
            this.FirstName = "";
            this.LastName = "";
        }
            public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    class Program{
        static void Main(string [] args ){
            Person p = new Person("John","Doe");
            Console.WriteLine(p.FullName);
        }
    }
}