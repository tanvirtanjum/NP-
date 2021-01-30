using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace NP__.Operation
{
    internal class OpenSave
    {
        readonly OpenFileDialog ofd;
        readonly SaveFileDialog sfd;
        string txtwrite="";
        internal string OF()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Text file (*.txt)|*.txt|C file (*.c)|*.c|C++ file (*.cpp)|*.cpp|C# file (*.cs)|*.cs|All file (*.*)|*.*";
            ofd.DefaultExt = "txt";
            ofd.FilterIndex = 5;

            if (ofd.ShowDialog() == true)
            {
                try { txtwrite = File.ReadAllText(ofd.FileName);}
                catch (Exception ex) { throw ex; }
                return txtwrite;
            }
            return txtwrite;
        }

        internal void SF(string swrite)
        {
            while (swrite != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                {
                    //sfd.FileName = WriteTB.Text.Substring(0,1);
                    sfd.FileName = "*";
                    sfd.Filter = "Text file (*.txt)|*.txt|C file (*.c)|*.c|C++ file (*.cpp)|*.cpp|C# file (*.cs)|*.cs|All file (*.*)|*.*";
                    //sfd.InitialDirectory = @"C:\"; 
                    //sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    sfd.DefaultExt = "txt";
                    sfd.FilterIndex = 5;
                    sfd.RestoreDirectory = true;
                    sfd.Title = "Save File";
                    sfd.CheckFileExists = false;
                    sfd.CheckPathExists = false;
                    sfd.OverwritePrompt = true;
                    sfd.ValidateNames = true;
                };

                while (sfd.ShowDialog() == true)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, swrite);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    break;
                }
                break;
            }
        }
    }
}
