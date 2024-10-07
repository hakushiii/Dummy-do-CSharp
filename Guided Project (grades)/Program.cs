
//Functions go brr
static void calculateGrades(string name, int[] scores, int gradedAssignments){
    decimal sum = 0;
    decimal examScore = 0;
    decimal extraCredit = 0;
    decimal sumExtraCredit = 0;
    string letterGrade = "";
    int extraCounter = 0;
    foreach (int i in scores){
        extraCounter++;
        if (extraCounter < gradedAssignments){
            sum += i;
        }
        else if (extraCounter == gradedAssignments){
            sum += i;
            examScore = sum / gradedAssignments;
        }
        else {
            extraCredit += i;
        }
    }
    extraCredit /= extraCounter - gradedAssignments;
    sumExtraCredit = extraCredit / 10 / gradedAssignments * (extraCounter - gradedAssignments);
    decimal average = examScore + sumExtraCredit;

    if (average >= 97)
        letterGrade = "A+";

    else if (average >= 93)
        letterGrade = "A";

    else if (average >= 90)
        letterGrade = "A-";

    else if (average >= 87)
        letterGrade = "B+";

    else if (average >= 83)
        letterGrade = "B";

    else if (average >= 80)
        letterGrade = "B-";

    else if (average >= 77)
        letterGrade = "C+";

    else if (average >= 73)
        letterGrade = "C";

    else if (average >= 70)
        letterGrade = "C-";

    else if (average >= 67)
        letterGrade = "D+";

    else if (average >= 63)
        letterGrade = "D";

    else if (average >= 60)
        letterGrade = "D-";
    else
        letterGrade = "F";

    //Console.WriteLine($"{name}\t\t{average}\t{letterGrade}");
    Console.WriteLine($"{name}\t\t{examScore}\t\t{average}\t{letterGrade}\t{extraCredit} ({sumExtraCredit} pts)");
    
}

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };   

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[][] studentScores = new int[][] { sophiaScores, andrewScores, emmaScores, loganScores, beckyScores, chrisScores, ericScores, gregorScores };

Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

calculateGrades(studentNames[0], studentScores[0], currentAssignments);
calculateGrades(studentNames[1], studentScores[1], currentAssignments);
calculateGrades(studentNames[2], studentScores[2], currentAssignments);
calculateGrades(studentNames[3], studentScores[3], currentAssignments);
calculateGrades(studentNames[4], studentScores[4], currentAssignments);
calculateGrades(studentNames[5], studentScores[5], currentAssignments);
calculateGrades(studentNames[6], studentScores[6], currentAssignments);
calculateGrades(studentNames[7], studentScores[7], currentAssignments);

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();