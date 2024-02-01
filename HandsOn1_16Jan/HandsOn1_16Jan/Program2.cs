//using System;
//using System.Collections.Generic;
//using System.Linq;

//internal class Program2             // using Linq
//{
//    private static void Main(string[] args)
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Alice", GPA = 3.6 },
//            new Student { Name = "Bob", GPA = 3.2 },
//            new Student { Name = "Charlie", GPA = 3.8 }
//        };

//        List<Student> result = Student.FilterAndSort(students);

//        Console.WriteLine("Filtered and Sorted Students:");
//        Console.WriteLine("[ " + string.Join(" , ", result.Select(student => student.Name)) + " ]");    // select -> Convert Student objects to string names
//        //OR
//        foreach (var student in result)
//        {
//            Console.WriteLine(student.Name);
//        }
//    }
//}

//public class Student
//{
//    public string Name { get; set; }
//    public double GPA { get; set; }

//    public static List<Student> FilterAndSort(List<Student> students)
//    {
//        var filteredStudents = students.Where(student => student.GPA > 3.5);        // Filter students with GPA greater than 3.5
//        var sortedStudents = filteredStudents.OrderByDescending(student => student.GPA).ToList();       // Sort the filtered students in descending order based on GPA
//        return sortedStudents;
//    }
//}
