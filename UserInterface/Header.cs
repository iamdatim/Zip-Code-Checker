﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    internal class Header
    {
        public static char headerLine = '-';
        public static int headerLineWidth = 118;


        public static void HeaderDisplay(string message)
        {
            Console.Clear();
            Animation.ProcessLoading();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string(headerLine, headerLineWidth));
            Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CentreText(message, headerLineWidth));
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string(headerLine, headerLineWidth));
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static string CentreText(string text, int width)
        {
            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            int totalSpaces = width - text.Length;
            int leftSpaces = totalSpaces / 2;
            return new string(' ', leftSpaces) + text + new string(' ', totalSpaces - leftSpaces);
        }
    }
}
