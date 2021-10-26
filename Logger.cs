using IInterfaceApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterfaceApp
{
    public class Logger : ILogger
    {
        public string CreateLog(Exception ex)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("______________________________");
            builder.AppendLine(DateTime.UtcNow.ToString());
            builder.AppendLine(ex.Message);
            builder.AppendLine(ex.Source);
            builder.AppendLine(ex.StackTrace);
            return builder.ToString();
        }

        public void Log(string source)
        {
            string path = Directory.GetCurrentDirectory();
            path = Path.Combine(new string[] { path, "Logs" });

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(new string[] { path, "logs.txt" });

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            File.AppendAllText(path, source);
        }
    }
}
