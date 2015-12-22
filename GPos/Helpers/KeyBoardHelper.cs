using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace GPos.Helpers
{
    static public class KeyBoardHelper
    {
        static Process keyboardProc;

        public static void ShowKeyboard()
        {
            string progFiles = @"C:\Program Files\Common Files\Microsoft Shared\ink";
            string keyboardPath = Path.Combine(progFiles, "TabTip.exe");

            keyboardProc = Process.Start(keyboardPath);
        }

        public static void HideKeyboard()
        {
            keyboardProc.Kill();
          
        }

    }
}
