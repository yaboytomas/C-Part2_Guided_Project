﻿//initialize variables - graded assignments
int currentAssignments = 5;

int[] sophiaScores = { 90, 86, 87, 98, 100 };
int[] andrewScores = { 92, 89, 81, 96, 90 };
int[] emmaScores = { 90, 85, 87, 98, 68 };
int[] loganScores = { 90, 95, 87, 88, 96 };

string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum 
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t?");
}

Console.WriteLine("\nPress the Enter key to continue");
Console.ReadLine();
