'Isabella Dougherty
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/IsabellaDougherty/SayMyNameRedo.git

Option Explicit On
Option Strict On

Imports System
Module Operators
    Sub Main()
        Dim name As String
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        If name = "Emily" Then
            Console.WriteLine("Hello Emily! Welcome to this program! I hope you have a wonderful day!")
        ElseIf name = "Joe" Then
            Console.WriteLine("Hello Jow! Welcome to this program! I hope you have a wonderful day!")
        ElseIf name = "Isabella" Then
            Console.WriteLine("My creator has appeared. Please fix me")
        Else
            Console.WriteLine("You are not allowed here")
        End If

        Console.WriteLine("Press Enter to exit the menu.")
        Console.ReadLine()
    End Sub
End Module