using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class LINQClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Student
    {
        // Language-Integrated Query (LINQ) is a powerful set of technologies
        // based on the integration of query capabilities directly into the C# language.
        // The LINQ provides a consistent query experience to query objects (LINQ to Objects),
        // relational databases (LINQ to SQL),
        // and XML (LINQ to XML).
        public void GetStudentBook()
        {
            // string collection
            IList<string> studentsBook = new List<string>() { 
            ".Net Toutorial",
            "C++",
            "Java Toutorial"
            };

            // LINQ Query Syntax
            var book = from b in studentsBook                       
                       where b.Contains("Toutorial")
                       select b
                       ;
            // Query execution
            foreach (var student in book)
            {
                Console.WriteLine(student);
            }
        }

        public void GetStudent()
        {
            IList<LINQClass> student = new List<LINQClass>() { 
                new LINQClass() {Id=1, Name="Kin",Age=30}
            };
        }
    }
}
