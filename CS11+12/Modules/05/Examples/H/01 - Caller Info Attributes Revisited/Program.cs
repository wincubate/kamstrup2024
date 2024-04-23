using System.Runtime.CompilerServices;

C.Log("Houston, we have a problem!");

class C
{
    public static void Log(
     string logLine,
     [CallerMemberName] string? callerName = null,
     [CallerFilePath] string? callerFilePath = null,
     [CallerLineNumber] int callerLine = -1
 )
    {
        Console.WriteLine(logLine + " was reported. Detailed info:" + Environment.NewLine);
        Console.WriteLine("Caller Name: {0}", callerName);
        Console.WriteLine("Caller FilePath: {0}", callerFilePath);
        Console.WriteLine("Caller Line number: {0}", callerLine);
    }
}