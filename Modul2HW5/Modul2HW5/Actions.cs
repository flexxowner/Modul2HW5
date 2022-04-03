using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Modul2HW5;

public class Actions : IActions
{
    public bool Info()
    {
        Logger.AddLog(LogType.Info,"start method");
        return true;
    }

    public BusinessException Warning()
    {
        return new BusinessException("Skipped logic in method");
    }

    public void Error()
    {
        throw new Exception("I broke a logic");
    }
}