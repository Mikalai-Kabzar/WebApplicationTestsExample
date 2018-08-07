using System.Diagnostics;
using System.IO;

namespace TestRunner
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            var logs = Config.Default.Logs;
            var report = Config.Default.Report;
            var console = Config.Default.Console;
            var tests = Config.Default.Tests;

            //clear previous allure .json logs
            if (Directory.Exists(logs)) Directory.Delete(logs, true);

            var runner = new Runner();
            runner.Run(console, tests, args);
            runner.GenerateReport(logs, report);
            runner.OpenReport(report);
        }
    }
}
