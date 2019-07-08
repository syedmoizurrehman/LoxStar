﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ErrorLogger
{
    public static class ErrorLoggingService
    {
        public static IList<Error> Errors { get; } = new List<Error>();

        public static void GenerateError(int lineNumber, string message)
        {
            using (TextWriter ErrorWriter = Console.Error)
            {
                ErrorWriter.WriteLine($"At line {lineNumber}, " + message);
            }
        }
    }

    public struct Error
    {
        public string Message { get; }

        public int LineNumber { get; }

        public int ColumnNumber { get; }

        public Error(string message, int line, int column)
        {
            Message = message;
            LineNumber = line;
            ColumnNumber = column;
        }
    }
}
