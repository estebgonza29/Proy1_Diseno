using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proy1_Diseno_InvestSys.Controller
{
    class CSVLogger : Logger{
        public void log(string data) {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("Log.csv", true)) {
                    string[] lines = data.Split(',');
                    string line = "";
                    for (int i = 0; i < lines.Length; i++) {
                        if (i == lines.Length - 1) line += lines[i].Split(':')[1];
                        else line += lines[i].Split(':')[1] + ',';
                    }
                    file.WriteLine(line);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
