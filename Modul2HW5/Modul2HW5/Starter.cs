using System.Text;
using Newtonsoft.Json;

namespace Modul2HW5;

public static class Starter
{
    public static void Run()
    {
        var random = new Random();
        var action = new Actions();
        var MyEx = new BusinessException();

        for (int i = 0; i < 100; i++)
        {
            var Index = random.Next(1, 4);

            switch (Index)
            {
                case 1:
                    action.Info();
                    break;
                case 2:
                    action.Warning();
                    Logger.AddLog(LogType.Warning, $"Action got this custom Exception :{MyEx.Message}");
                    break;
                case 3:
                    try
                    {
                        action.Error();
                    }
                    catch (Exception ex)
                    {
                        Logger.AddLog(LogType.Error, $"Action failed by reason:{ex.Message}");
                    }
                    break;
            }
        }
        
        var data = Logger.GetItems();

        StringBuilder builder = new StringBuilder();

        foreach (var item in data)
        {
            builder.Append($"{item.Date}, {item.Type}, {item.Message} \n");
        }
        Console.WriteLine(builder.ToString());
        
        FileService.AddToFile(data);
        
    }
}