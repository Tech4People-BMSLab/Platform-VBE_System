using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    static class RecordData
    {
        
        static private string path = @"c:\Data\";
        private static string timestamp;
        private static string pathString;

        public static void start(string timestamp)
        {
            RecordData.timestamp = timestamp;
            pathString = System.IO.Path.Combine(path, timestamp);
            System.IO.Directory.CreateDirectory(pathString);
            //path = System.IO.Path.Combine(pathString, fileName);
        }

        public  static void writeEmpatica(string device, string command, string content)
        {
            
            if (Form1.record)
            {
                string devicePath = System.IO.Path.Combine(pathString, device);
                if (!System.IO.Directory.Exists(devicePath))
                {
                    System.IO.Directory.CreateDirectory(devicePath);
                }
                //String timeStamp = (System.Diagnostics.Stopwatch.GetTimestamp()).ToString();
                string text = "";
                switch (command)
                {
                    case "acc":
                        text = content;
                        break;
                    case "bvp":
                        text = content;
                        break;
                    case "gsr":
                        text = content;
                        break;
                    case "ibi":
                        text = content;
                        break;
                    case "tmp":
                        text = content;
                        break;

                }
                string fileString = System.IO.Path.Combine(devicePath, command + ".csv");
                using (StreamWriter sw = File.AppendText(fileString)) 
                {
                    text = checkAndReplaceText(text);
                    sw.WriteLine(text); 
                    sw.Close();
                }

            }
      
        //    StreamWriter sw = File.AppendText(fname);
        //    all = "##::##::" + time + "::" + eventd + "==" + descd;
        //    all = EncodeTo64(all);
        //    sw.WriteLine(all + "\n\r");
        //    sw.Close();
           //using (StreamWriter sw = new StreamWriter(file))
           //{
           //   sw.Write(content);
           //}
        }
        private static string checkAndReplaceText( string text)
        {            
            
            foreach (var v in text)
            {
                text = text.Replace(" ", ",");
            }
            return Regex.Replace(text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
            }
    }
}
     