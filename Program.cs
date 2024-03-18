// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Assignment_Planner;
 
    
        while (true)
        {
            Console.WriteLine("1. Add Assignment");
            Console.WriteLine("2. Add Study Plan");
            Console.WriteLine("3. View Assignments");
            Console.WriteLine("4. View Study Plans");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Assignment.AddAssignment();
                    break;
                case "2":
                    StudyPlan.AddStudyPlan();
                    break;
                case "3":
                    Assignment.ViewAssignments();
                    break;
                case "4":
                    StudyPlan.ViewStudyPlans();
                    break;
                // case "5":
                //    Environment.Exit(0);
                //     break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    

