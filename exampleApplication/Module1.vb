Imports System

Module Module1
    Sub Main()
        someShittySub()
    End Sub

    Sub someShittySub()
        Console.Title = "some cheap ass logger"
        Dim userInput As String
        Dim logFile As Logger = New Logger()
        logFile.Logger("myLog.log")
        While True
            Console.WriteLine("prefixes = warning, msg, var")
            userInput = Console.ReadLine()
            If (userInput.Contains("warning")) Then
                logFile.LogToFile(Logger.LogType.Warning, userInput, "description")
            ElseIf (userInput.Contains("msg")) Then
                logFile.LogToFile(Logger.LogType.Message, userInput, "description")
            ElseIf (userInput.Contains("var")) Then
                logFile.LogToFile(Logger.LogType.VariableDump, userInput, "description")
            Else
                Console.WriteLine("you didn't include any keywords...")
            End If

        End While
    End Sub



End Module
