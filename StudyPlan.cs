using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_Planner
{
    public class StudyPlan : Base
    {
      static List<StudyPlan> studyplan = new List<StudyPlan>();  

       public string Topic { get; set; }

       public StudyPlan(string topic, DateTime startDateTime, DateTime endDateTime)
    {
        Topic = topic;
        StartDateTime = startDateTime;
        EndDateTime = endDateTime;
    }

      public static void AddStudyPlan()
    {
       
        Console.Write("Enter study plan topic: ");
        string topic = Console.ReadLine();

        Console.Write("Enter study plan start date and time (YYYY-MM-DD HH:mm): ");
        DateTime startDateTime = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter study plan end date and time (YYYY-MM-DD HH:mm): ");
        DateTime endDateTime = DateTime.Parse(Console.ReadLine());
        bool isOccupied = false;

        foreach (var item in studyplan )
        {
          if((item.StartDateTime <= startDateTime && startDateTime <= item.EndDateTime) || (item.StartDateTime <= endDateTime && endDateTime <= item.EndDateTime))
          {
            isOccupied = true;
            break;
          }
        }

        if(isOccupied)
        {
          Console.WriteLine(" The topic you've entered matches an existing topic, and the timeframe you've provided falls within the timeframe of the previous entry.");
        }
        else
        {
           StudyPlan newStudyPlan = new StudyPlan(topic, startDateTime, endDateTime);
          studyplan.Add(newStudyPlan);
        Console.WriteLine("Study plan added successfully!");
        }

        
    }

     public static void ViewStudyPlans()
    {
        Console.WriteLine("Study Plans:");
        foreach (StudyPlan studyPlan in studyplan)
        {
            Console.WriteLine($"Topic: {studyPlan.Topic}");
            Console.WriteLine($"Start Date and Time: {studyPlan.StartDateTime.ToString("yyyy-MM-dd HH:mm")}");
            Console.WriteLine($"End Date and Time: {studyPlan.EndDateTime.ToString("yyyy-MM-dd HH:mm")}");
            Console.WriteLine();
        }
    }





      

    //    static void AddStudyPlan()
    // {
    //     Console.Write("Enter yourstudy plan : ");
    //     string assignmentName = Console.ReadLine();

    //     Assignment assignment = assignments.Find(a => a.Name == assignmentName);
    //     if (assignment == null)
    //     {
    //         Console.WriteLine("Assignment not found.");
    //         return;
    //     }

    //     Console.WriteLine("Enter study plan start date and time (YYYY-MM-DD HH:mm): ");
    //     DateTime studyPlanStartDate = DateTime.Parse(Console.ReadLine());

    //     Console.WriteLine("Enter study plan end date and time (YYYY-MM-DD HH:mm): ");
    //     DateTime studyPlanEndDate = DateTime.Parse(Console.ReadLine());

    //     StudyPlan newStudyPlan = new StudyPlan(studyPlanStartDate, studyPlanEndDate);
    //     assignment.StudyPlans.Add(newStudyPlan);

    //     Console.WriteLine("Study plan added successfully!");
    // } 
      


    }


}