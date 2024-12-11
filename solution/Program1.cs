internal class Program1
{
    private static void Main(string[] args)
    {
        int currentAssignments = 5;
        int examAssignments = 5;
        String gradeLetter = "";

        //initialising Student list
        String[] students = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" ];

        //initilaising student's marks
        int[] sophiaMarks = [90, 86, 87, 98, 100, 94, 90];
        int[] andrewMarks = [92, 89, 81, 96, 90, 89];
        int[] emmaMarks = [90, 85, 87, 98, 68, 89, 89, 89];
        int[] loganMarks = [90, 95, 87, 88, 96, 96];
        int[] beckyScores =  [92, 91, 90, 91, 92, 92, 92];
        int[] chrisScores =  [84, 86, 88, 90, 92, 94, 96, 98];
        int[] ericScores =  [80, 90, 100, 80, 90, 100, 80, 90];
        int[] gregorScores =  [91, 91, 91, 91, 91, 91, 91];
        
        int[] scores = new int[10];

        Console.WriteLine("Student\t\tGrade");
        Console.WriteLine("");
        
        foreach (var name in students)
        {
             if (name == "Sophia")
             {
                scores = sophiaMarks;
             }
             else if (name == "Andrew")
             {
                scores = andrewMarks;
             }
             else if (name =="Emma")
             {
                scores = emmaMarks;
             }
             else if(name == "Logan")
             {
                scores = loganMarks;
             }
            else if (name == "Becky")
                scores = beckyScores;
            else if (name == "Chris")
                scores = chrisScores;
            else if (name == "Eric")
                scores = ericScores;
            else if (name == "Gregor")
                scores = gregorScores;
            else
                continue;
             
             int sum = 0;
             int gradedAssignments = 0;
             
             foreach (var score in scores)
             {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    // add the exam score to the sum
                    sum+= score;

                else
                    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                    sum += score / 10;
             }
            
            decimal studGrade = (decimal) sum/currentAssignments;

            //Assigning different grade letter according to student grades
            if (studGrade >= 97)
                gradeLetter = "A+";

            else if (studGrade >= 93)
                gradeLetter = "A";

            else if (studGrade >= 90)
                gradeLetter = "A-";

            else if (studGrade >= 87)
                gradeLetter = "B+";

            else if (studGrade >= 83)
                gradeLetter = "B";

            else if (studGrade >= 80)
                gradeLetter = "B-";

            else if (studGrade >= 77)
                gradeLetter = "C+";

            else if (studGrade >= 73)
                gradeLetter = "C";

            else if (studGrade >= 70)
                gradeLetter = "C-";

            else if (studGrade >= 67)
                gradeLetter = "D+";

            else if (studGrade >= 63)
                gradeLetter = "D";

            else if (studGrade >= 60)
                gradeLetter = "D-";
            
            else
                gradeLetter = "F";

            Console.WriteLine($"{name}\t\t{studGrade}\t{gradeLetter}"); 
        }
        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}
