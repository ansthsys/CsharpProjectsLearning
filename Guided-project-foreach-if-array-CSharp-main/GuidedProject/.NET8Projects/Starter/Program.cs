using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[][90, 86, 87, 98, 100];
int[] andrewScores = new int[][92, 89, 81, 96, 90];
int[] emmaScores = new int[][90, 85, 87, 98, 68];
int[] loganScores = new int[][90, 95, 87, 88, 96];

string[] studentNames = new string[]["sophia", "andrew", "emma", "logan"];
int[] scores = new int[10];

foreach (var name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "sophia") scores = sophiaScores;
    if (currentStudent == "andrew") scores = andrewScores;
    if (currentStudent == "emma") scores = emmaScores;
    if (currentStudent == "logan") scores = loganScores;

    int sumAssignmentScores = 0;
    decimal currentStudentScore = 0;

    foreach (var score in scores)
    {
        sumAssignmentScores += score;
    }

    currentStudentScore = (decimal)sumAssignmentScores / currentAssignments;
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}
