using System.Net.Http.Headers;

namespace Modul2HW5;

public class LogItem
{
    public  DateTime Date { get; private set; }
    
    public  LogType Type { get; private set; }
    
    public  string Message { get; private set; }

    public LogItem(LogType type, string message)
    {
        Date = DateTime.Now;
        Type = type;
        Message = message;
    }
}