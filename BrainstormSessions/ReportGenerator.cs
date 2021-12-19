using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BrainstormSessions
{
    public class ReportGenerator
    {
        public void GenerateLogReport(string readPath, string writePath)
        {
            string line;
            int debugCount = 0;
            int infoCount = 0;
            int errorCount = 0;
            var errorList = new List<string>();
            using (var sr = new StreamReader(readPath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("DEBUG", System.StringComparison.OrdinalIgnoreCase))
                    {
                        debugCount++;
                    }
                    if (line.Contains("INFO", System.StringComparison.OrdinalIgnoreCase))
                    {
                        infoCount++;
                    }
                    if (line.Contains("Error", System.StringComparison.OrdinalIgnoreCase))
                    {
                        errorList.Add(line);
                        errorCount++;
                    }
                }
            }

            using (var sw = new StreamWriter(writePath))
            {
                sw.WriteLine($"DEBUG Count: {debugCount}");
                sw.WriteLine($"INFO Count: {infoCount}");
                sw.WriteLine($"ERROR Count: {errorCount}");
                if (errorList.Count > 0)
                {
                    foreach(var error in errorList)
                        sw.WriteLine(error);
                }
            }
        }
    }
}
