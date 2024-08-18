namespace C_HelpfulPatterns;

//Дано: Інтерфейс ILogger та його реалізація ConsoleLogger.
//Завдання: Впровадьте залежність ILogger у клас UserService за допомогою конструктора.
internal interface ILogger { }

class ConsoleLogger : ILogger { }

class UserService
{
    private ILogger _logger;

    public UserService(ILogger logger)
    {
        _logger = logger;
    }
}
