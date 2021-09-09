using System;

namespace UnitTestAndDebug
{
    public class Person
    {
        public Person(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        private string name;
 
        private string id;

        public string Name
        {
            get
            {
                return this.name;
            }
            
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    Console.WriteLine("Error con el nombre.");
                    this.name = null; 
                }
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id = value;
                }
                else
                {
                    Console.WriteLine("Error con el ID.");
                    this.id = ""; 
                }
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Soy {this.Name} y mi cédula es {this.Id}");
        }
    }
}
