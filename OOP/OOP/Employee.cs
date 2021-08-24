using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee : User, Login
    {
        public Employee()
        {
        }
        List<Employee> employee = new List<Employee>();
        public Employee(string firstname, string lastname, string username, string pass)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.pass = pass;
        }

        private string username
        { get; set; }
        private string pass
        { get; set; }
        



        public bool login(string user, string password)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                if (user == employee[i].username)
                {
                    if (password == employee[i].pass)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
          
        }

        public void register()
        {
            Console.WriteLine("FirstName : ");
            firstname = Console.ReadLine();
            Console.WriteLine("Lastname : ");
            lastname = Console.ReadLine();
            Console.WriteLine("Username : ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            pass = Console.ReadLine();
            employee.Add(new Employee(firstname, lastname,username, pass));
        }

        public void show()
        {

            Console.WriteLine("===============================");
            for (int i = 0; i < employee.Count; i++)
            {
                Console.WriteLine("Firstname          : " + employee[i].firstname);
                Console.WriteLine("Lastname           : " + employee[i].lastname);
                Console.WriteLine("Username           : " + employee[i].username);
                Console.WriteLine("===============================");
            }
           
        }

        public void search()
        {
            string[] stockArr = new String[employee.Count()];
            
                ;
            
            




        }
    }



}
