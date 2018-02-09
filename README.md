# VB_Logger
Simple class to add easy logging options in VB

### Usage
	`Dim logFile As Logger = New Logger()
     logFile.Logger("myLog.log")
     logFile.LogToFile(Logger.LogType.Warning, "This is a warning", "Description")`

results in a `myLog.log` with contents :
	`19:11:29:    Warning    Description   This is a warning`

New lines are automatically added, and after every `logger` initialization, a visible divider is added to the log file to differentiate between new sessions
