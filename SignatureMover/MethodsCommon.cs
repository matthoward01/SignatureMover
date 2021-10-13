using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SignatureMover.Properties;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace SignatureMover
{
    class MethodsCommon
    {
        public bool networkCheck()
        {
            bool status = true;
            List<string> paths = new List<string>();
            paths.Add(Settings.Default.InputPath);
            paths.Add(Settings.Default.TextProcessPath);
            paths.Add(Settings.Default.TextCompletedPath);
            paths.Add(Settings.Default.JpgOutputPath);   

            foreach (var path in paths)
            {
                if (!Directory.Exists(path))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please connect to " + path);
                    Console.ResetColor();
                    Console.WriteLine("-------------------------------------------------------------");
                    status = false;
                }
            }
            return status;
        }
        public bool IsFileLocked(string passedFile)
        {
            FileStream stream = null;

            try
            {
                stream = File.Open(passedFile, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}
