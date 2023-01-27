'Chris Pickens
'RCET0265
'Spring 2023
'Say My Name Again
'https://github.com/Pickchr2/SayMyNameAgain.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System

Module Program
    Sub Main(args As String())
        Dim userInput As String

        Console.WriteLine("Please enter the name of an employee to find out their assigned duty...")
        userInput = Console.ReadLine()

        Select Case userInput
            Case "Emily"
                Console.WriteLine($"{userInput}'s assigned work duty is to sort 9999 resistors before lunch.")
            Case "Joe"
                Console.WriteLine($"{userInput}'s assigned work duty is to investigate who killed the snowcone machine.")
            Case "Chris"
                Console.WriteLine($"{userInput}'s assigned work duty is to do...whatever it is they do around here..")
            Case "Tim"
                Console.WriteLine($"{userInput}'s assigned work duty is to award this assignment an A!")
            Case Else
                Console.WriteLine($"We have no employee of record named {userInput}.")
        End Select
    End Sub
End Module
