using System;

namespace arayuzler // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new();
            smsLogger.WriteLog();

            Console.WriteLine("********");
            
            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}