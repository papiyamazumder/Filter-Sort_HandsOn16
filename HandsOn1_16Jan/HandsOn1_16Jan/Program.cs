using System.Collections.Generic;

internal class Program            // using sorted list
{
    private static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", GPA = 3.6 },
            new Student { Name = "Bob", GPA = 3.2 },
            new Student { Name = "Charlie", GPA = 3.8 }
        };

        SortedList<double, string> sl = new SortedList<double, string>();   // create sorted list to automatically sort 

        foreach (Student s in students)             // sort automatically based on GPA
        {
            sl.Add(s.GPA, s.Name);
        }

        Student studentobj = new Student();         //create object of student class to call the method
        List<String> outputlist = studentobj.FilterAndSort(sl);        // call and store the function in a list of string

        outputlist.Reverse();                       // reverse for descending order

        Console.WriteLine("[ " + string.Join(" , ", outputlist) + " ]");        // print in desired format
        // OR
        foreach (var s in outputlist)
        {
            Console.WriteLine(s);
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }

    public List<String> FilterAndSort(SortedList<double, string> sl)       // return list and take parameter sorted list
    {
        var filteredlist = new List<String>();

        foreach (var s in sl)
        {
            if (s.Key > 3.5)                                // add values acc to qustn condition
            {
                filteredlist.Add(s.Value);
            }
        }
        return filteredlist;
    }

}


