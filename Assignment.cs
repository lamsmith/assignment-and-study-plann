using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Planner 
{
    public class Assignment : Base
    {
         public string Name { get; set; }
        static List<Assignment> assignments = new List<Assignment>();
     

    public Assignment(string name, DateTime startDate, DateTime endDate)
    {
        Name = name;
        StartDateTime = startDate;
        EndDateTime = endDate;
    }

    public static void AddAssignment()
    {
        Console.Write("Enter assignment name: ");
        string assignmentName = Console.ReadLine();

        Console.Write("Enter starting date (YYYY-MM-DD): ");
        DateTime startDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter ending date (YYYY-MM-DD): ");
        DateTime endDate = DateTime.Parse(Console.ReadLine());

        Assignment newAssignment = new Assignment(assignmentName, startDate, endDate);
        assignments.Add(newAssignment);

        Console.WriteLine("Assignment added successfully!");
    }

   public static void ViewAssignments()
    {
        Console.WriteLine("Assignments:");
        foreach (Assignment assignment in assignments)
        {
            Console.WriteLine($"Assignment Name: {assignment.Name}");
            Console.WriteLine($"Start Date: {assignment.StartDateTime}");
            Console.WriteLine($"End Date: {assignment.EndDateTime}");

           
        }
    }

    






//     static void ViewAssignments()
// {
//     Console.WriteLine("Current Assignments:");
//     foreach (Assignment assignment in assignments)
//     {
//         Console.WriteLine($"Assignment: {assignment.Name}");
//         Console.WriteLine($"Starting Date: {assignment.StartDate.ToString("yyyy-MM-dd")}");
//         Console.WriteLine($"Ending Date: {assignment.EndDate.ToString("yyyy-MM-dd")}");
//         Console.WriteLine();
//     }
// }
    }
}