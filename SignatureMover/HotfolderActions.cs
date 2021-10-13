using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SignatureMover.Properties;
using System.IO;
using System.Drawing;

namespace SignatureMover
{   
    class HotfolderActions
    {
        MethodsCommon methods = new MethodsCommon();

        public void txtFileHandler(FormMain mainForm, string passedFile)
        {       
            string inputFile = Path.GetFileNameWithoutExtension(passedFile) + " --- " + DateTime.Now + Path.GetExtension(passedFile);
            inputFile = inputFile.Replace("/", "-").Replace(":", "");
            string inputPath = Settings.Default.InputPath;
            string outputPath = Settings.Default.TextProcessPath;
            string outputPathCopy = Settings.Default.TextCompletedPath;

            string combinedInputFile = System.IO.Path.Combine(inputPath, passedFile);
            string combinedOutputFile = System.IO.Path.Combine(outputPath, inputFile);
            string combinedOutputFileCopy = System.IO.Path.Combine(outputPathCopy, inputFile);

            if (!methods.IsFileLocked(combinedInputFile))
            {
                System.IO.File.Copy(combinedInputFile, combinedOutputFile, true);
                System.IO.File.Copy(combinedInputFile, combinedOutputFileCopy, true);

                mainForm.BeginInvoke(new Action(() => { mainForm.rtbOutputText.AppendText(DateTime.Now + " | <<" + passedFile + ">> has been copied. \r\n", Color.Green, FontStyle.Regular); }));

                if (File.Exists(combinedInputFile))
                {
                    File.Delete(combinedInputFile);
                }  
            }          
        }

        public void jpgFileHandler(FormMain mainForm, string passedFile)
        {
            string inputFile = passedFile;
            string inputFileDup = Path.GetFileNameWithoutExtension(passedFile) + " --- " + DateTime.Now + Path.GetExtension(passedFile);
            inputFileDup = inputFileDup.Replace("/", "-").Replace(":", "");
            string inputPath = Settings.Default.InputPath;
            string outputPath = Settings.Default.JpgOutputPath;
            string duplicateOutputPath = Settings.Default.JpgDuplicatePath;

            string combinedInputFile = System.IO.Path.Combine(inputPath, passedFile);
            string combinedOutputFile = System.IO.Path.Combine(outputPath, Path.GetFileNameWithoutExtension(inputFile).Substring(Path.GetFileNameWithoutExtension(inputFile).Length - 6), inputFile);
            string combinedDuplicateOutputFile = System.IO.Path.Combine(duplicateOutputPath, inputFileDup);

            if (!methods.IsFileLocked(combinedInputFile))
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(outputPath, Path.GetFileNameWithoutExtension(inputFile).Substring(Path.GetFileNameWithoutExtension(inputFile).Length - 6)));
                if (!File.Exists(combinedOutputFile))
                {
                    System.IO.File.Copy(combinedInputFile, combinedOutputFile, true);
                    mainForm.BeginInvoke(new Action(() => { mainForm.rtbOutputText.AppendText(DateTime.Now + " | <<" + inputFile + ">> has been copied. \r\n", Color.Green, FontStyle.Regular); }));
                }
                else
                {                    
                    System.IO.File.Copy(combinedInputFile, combinedDuplicateOutputFile, true);
                    mainForm.BeginInvoke(new Action(() => { mainForm.rtbOutputText.AppendText(DateTime.Now + " | <<" + inputFile + ">> Already exists placing in duplicate folder. \r\n", Color.Red, FontStyle.Regular); }));
                }
                
                if (File.Exists(combinedInputFile))
                {
                    File.Delete(combinedInputFile);
                }
            }
        }
    }
}
