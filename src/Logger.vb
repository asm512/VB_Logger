Imports System.IO

Public Class Logger

    Dim path As String

    Function Logger(Optional logfilePath As String = "logFile.log")
        path = logfilePath
    End Function

    Public Enum LogType
        Message
        Warning
        VariableDump
    End Enum

    Function LogToFile(logType As LogType, message As String, Optional description As String = "") As Task
        Select Case logType
            Case LogType.Message
                message = String.Concat(DateTime.Now.ToLongTimeString, ":    ", "Message", "    ", description, "   ", message)
            Case LogType.Warning
                message = String.Concat(DateTime.Now.ToLongTimeString, ":    ", "Warning", "    ", description, "   ", message)
            Case LogType.VariableDump
                message = String.Concat(DateTime.Now.ToLongTimeString, ":    ", "Variable", "    ", description, "   ", message)
        End Select
        File.AppendAllText(path, message + vbCrLf)
    End Function




End Class
