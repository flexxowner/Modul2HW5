using System.Text;
using Newtonsoft.Json;

namespace Modul2HW5;

public static class FileService
{
    public static void AddToFile(List<LogItem> info)
    {
        var configFile = File.ReadAllText("C:\\Users\\romav\\RiderProjects\\Modul2HW5\\Modul2HW5\\config.json");
        var configs = JsonConvert.DeserializeObject<Config>(configFile);
        string writePath = $"{configs?.Logger.DirectoryPath}\\{configs?.Logger.FileName}.{configs?.Logger.FileExtension}";
        StringBuilder stringBuilder = new StringBuilder();
        try
        {
            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                foreach (var item in info)
                {
                    stringBuilder.Append($"{item.Date}, {item.Type}, {item.Message} \n");
                }
                sw.WriteLine(stringBuilder.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}