using LanguageFeatures.MyExtensions;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExtensionMethodForString();

            IEnumerable<Employee> employees = new Employee[]
            {
                new Employee() {Id = 4, Name = "Theodor"},
                new Employee() {Id = 1, Name = "Fredrik"},
                new Employee() {Id = 2, Name = "Ellen"},

            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee{ Id = 4, Name = "Robert"}
            };

            // int[] numbers = new[] { 1, 2, 3, 4, 5 };
            // Console.WriteLine(numbers.Count());

            Console.WriteLine(employees.Count());

            //var query = employees.Where(NameIsSevenCharatersLong);

            //var query = employees.Where(e => (e.Name.Length == 7 && e.Name.StartsWith("F")) )
            //                     .OrderBy(e => e.Name);

            var query = employees.Filter(e => e.Name.Length == 7);



            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine("---");

            //var enumerator = employees.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    var employee = enumerator.Current;
            //    Console.WriteLine(employee.Name);
            //}




        }

        private static bool NameIsSevenCharatersLong(Employee employee)
        {
            return employee.Name.Length == 7;
        }

        private static bool StartsWithE(Employee employee)
        {
            return employee.Name.StartsWith("E");
        }

        private static void ExtensionMethodForString()
        {
            //double tal = MyExtensions.StringExtensions.ToDouble(Console.ReadLine(), -1);
            //var d = "123,45".ToDouble();
            //double tal = Console.ReadLine().ToDouble(-1);
            //Console.WriteLine(tal);
        }
    }
}
