// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentNames = ["sophia", "andrew", "emma", "logan", "Becky", "Chris", "Eric", "Gregor"];
int[] scores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (var name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "sophia") scores = sophiaScores;
    else if (currentStudent == "andrew") scores = andrewScores;
    else if (currentStudent == "emma") scores = emmaScores;
    else if (currentStudent == "logan") scores = loganScores;
    else if (currentStudent == "Becky") scores = beckyScores;
    else if (currentStudent == "Chris") scores = chrisScores;
    else if (currentStudent == "Eric") scores = ericScores;
    else if (currentStudent == "Gregor") scores = gregorScores;
    else continue;

    int sumAssignmentScores = 0;
    decimal currentStudentScore = 0;
    string currentStudentGrade;

    int index = 0;

    foreach (var score in scores)
    {
        if (index < currentAssignments)
        {
            sumAssignmentScores += score;
        }
        else
        {
            sumAssignmentScores += score / 10;
        }

        index++;
    }

    currentStudentScore = (decimal)sumAssignmentScores / currentAssignments;

    if (currentStudentScore >= 97)
        currentStudentGrade = "A+";
    else if (currentStudentScore >= 93)
        currentStudentGrade = "A";
    else if (currentStudentScore >= 90)
        currentStudentGrade = "A-";
    else if (currentStudentScore >= 87)
        currentStudentGrade = "B+";
    else if (currentStudentScore >= 83)
        currentStudentGrade = "B";
    else if (currentStudentScore >= 80)
        currentStudentGrade = "B-";
    else if (currentStudentScore >= 77)
        currentStudentGrade = "C+";
    else if (currentStudentScore >= 73)
        currentStudentGrade = "C";
    else if (currentStudentScore >= 70)
        currentStudentGrade = "C-";
    else if (currentStudentScore >= 67)
        currentStudentGrade = "D+";
    else if (currentStudentScore >= 63)
        currentStudentGrade = "D";
    else if (currentStudentScore >= 60)
        currentStudentGrade = "D-";
    else
        currentStudentGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{currentStudentScore}\t{currentStudentGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
