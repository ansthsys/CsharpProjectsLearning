// initialize variables - graded assignments
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

string[] studentNames = ["sophia", "andrew", "emma", "logan"];
int[] scores = new int[10];

// ===== CHANGED =====
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

foreach (var name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "sophia")
        scores = sophiaScores;
    else if (currentStudent == "andrew")
        scores = andrewScores;
    else if (currentStudent == "emma")
        scores = emmaScores;
    else if (currentStudent == "logan")
        scores = loganScores;

    // ===== CHANGED =====
    int examScoreSum = 0;
    int extraCreditScoreSum = 0;

    // ===== CHANGED =====
    decimal examScore = 0;
    decimal overallScore = 0;
    decimal extraCreditAverage = 0;
    decimal extraCreditPoints = 0;

    string currentStudentGrade = "";

    int index = 0;

    foreach (var score in scores)
    {
        // ===== CHANGED =====
        if (index < currentAssignments)
        {
            examScoreSum += score;
        }
        else
        {
            extraCreditScoreSum += score;
        }

        index++;
    }

    // ===== CHANGED =====
    int extraCreditAssignments = scores.Length - currentAssignments;

    // ===== CHANGED =====
    examScore = (decimal)examScoreSum / currentAssignments;

    // ===== CHANGED =====
    if (extraCreditAssignments > 0)
    {
        extraCreditAverage =
            (decimal)extraCreditScoreSum / extraCreditAssignments;
    }

    // ===== CHANGED =====
    extraCreditPoints =
        ((decimal)extraCreditScoreSum * 0.1m) / currentAssignments;

    // ===== CHANGED =====
    overallScore =
        (examScoreSum + ((decimal)extraCreditScoreSum * 0.1m))
        / currentAssignments;

    // ===== CHANGED =====
    if (overallScore >= 97)
        currentStudentGrade = "A+";
    else if (overallScore >= 93)
        currentStudentGrade = "A";
    else if (overallScore >= 90)
        currentStudentGrade = "A-";
    else if (overallScore >= 87)
        currentStudentGrade = "B+";
    else if (overallScore >= 83)
        currentStudentGrade = "B";
    else if (overallScore >= 80)
        currentStudentGrade = "B-";
    else if (overallScore >= 77)
        currentStudentGrade = "C+";
    else if (overallScore >= 73)
        currentStudentGrade = "C";
    else if (overallScore >= 70)
        currentStudentGrade = "C-";
    else if (overallScore >= 67)
        currentStudentGrade = "D+";
    else if (overallScore >= 63)
        currentStudentGrade = "D";
    else if (overallScore >= 60)
        currentStudentGrade = "D-";
    else
        currentStudentGrade = "F";

    // ===== CHANGED =====
    Console.WriteLine(
        $"{currentStudent}\t\t{examScore:F1}\t\t{overallScore:F2}\t{currentStudentGrade}\t{extraCreditAverage:F0} ({extraCreditPoints:F2} pts)"
    );
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();