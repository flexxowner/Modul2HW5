using Newtonsoft.Json;

namespace Modul2HW5;

public class Logger
{
    private static List<LogItem> _items = new List<LogItem>();
    
    private static Logger _instance;

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }
    }
    private  Logger(){}

    public static  void AddLog(LogType type, string message)
    {
        _items.Add(new LogItem(type,message));
    }

    public static List<LogItem> GetItems()
    {
        return _items;
    }
    
}