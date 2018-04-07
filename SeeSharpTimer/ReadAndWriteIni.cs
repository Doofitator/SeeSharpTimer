using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace SeeSharpTimer
{
    class ReadAndWriteIni
    {
        [DllImport("kernel32.dll", EntryPoint = "WritePrivateProfileStringW")]
        static extern Int32 WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

        public static void writeIni(string iniFileName, string Section, string ParamName, string ParamVal)
        {
            int Result = WriteIni.WritePrivateProfileString(Section, ParamName, ParamVal, iniFileName);
            return Result;
        }

        public static void deleteKeyFromIni(string iniFileName, string Section, string ParamName)
        {
            string Result = WriteIni.WritePrivateProfileString(Section, ParamName, null, iniFileName);
            return Result;
        }


        [DllImport("kernel32.dll")]
        static extern int GetPrivateProfileStringW(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

        public static void ReadIni(string Filename, string AppName, string KeyName)
        {
            // make vars
            object Exists = false;
            if (System.IO.File.Exists(Filename))
            {
                Exists = true;
            }

            // Read Ini
            if ((Exists == true))
            {
                StringBuilder sb = new StringBuilder(500);
                int result = ReadIni.GetPrivateProfileStringW(AppName, KeyName, "", sb, sb.Capacity, Filename);
                if ((result > 0))
                {
                    return sb.ToString();
                }
                else
                {
                    Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
                    return ("ERROR: " + ex.Message);
                }

            }
            else
            {
                return "Error: File not found";
            }

        }
    }

}
