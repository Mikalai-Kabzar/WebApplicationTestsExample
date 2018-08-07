using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace TestRunner
{
    internal class Runner
    {
        public void Run(string filePath, string testFilePath, string[] args)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = filePath,
                Arguments = $"{ testFilePath } { string.Join(" ", args.Where(arg => !string.IsNullOrEmpty(arg))) }"
            };

            var process = new Process
            {
                StartInfo = processInfo
            };

            process.Start();
            process.WaitForExit();
        }

        public void GenerateReport(string logs, string output)
        {
            if (Directory.Exists(output)) Directory.Delete(output, true);

            var info = new ProcessStartInfo
            {
                Arguments = $"/C allure generate {logs} -o {output}",
                FileName = Environment.GetEnvironmentVariable("COMSPEC")
            };

            var process = new Process
            {
                StartInfo = info
            };

            var env = Environment.GetEnvironmentVariables();

            process.Start();
            process.WaitForExit();
        }

        public void OpenReport(string output)
        {
            Process.Start(string.Concat(Directory.GetCurrentDirectory(), @"\", output, @"\index.html"));
        }
    }
}