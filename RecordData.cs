using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VBEApp_v1._0
{
    static class RecordData
    {

        static private string path = @"c:\Data\";
        private static string timestamp;
        private static string pathString;

        public static void start(string timestamp)
        {
            RecordData.timestamp = timestamp;
            pathString = Path.Combine(path, timestamp);
            Directory.CreateDirectory(pathString);
            //path = System.IO.Path.Combine(pathString, fileName);
        }

        public static void writeEmpatica(string device, string command, string content)
        {

            if (MainWindow.record)
            {
                string devicePath = Path.Combine(pathString, device);
                if (!Directory.Exists(devicePath))
                {
                    Directory.CreateDirectory(devicePath);
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
                    case "bat":
                        text = content;
                        break;
                    case "tag":
                        text = content;
                        break;

                }
                string fileString = Path.Combine(devicePath, command + ".csv");
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
        private static string checkAndReplaceText(string text)
        {

            foreach (var v in text)
            {
                text = text.Replace(" ", ",");
            }
            return Regex.Replace(text, @"^\s*$\n|\r", "", RegexOptions.Multiline).TrimEnd();
        }
    }
}
