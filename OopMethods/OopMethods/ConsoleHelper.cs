using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    public static class ConsoleHelper
    {
        /// <summary>
        /// Prints a message in console.
        /// </summary>
        /// <param name="message">The message.</param>
        public static void PrintMessage(string message)
        {
            PrintMessage(null, message, 1);
        }

        /// <summary>
        /// Prints a message with a label.
        /// </summary>
        /// <param name="label">The label.</param>
        /// <param name="message">The message.</param>
        public static void PrintMessage(string label, string message)
        {
            PrintMessage(label, message, 1);
        }

        /// <summary>
        /// Prints a message multiple times.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="count">The number of times.</param>
        public static void PrintMessage(string message, int count)
        {
            PrintMessage(null, message, count);
        }

        private static void PrintMessage(string label, string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (string.IsNullOrEmpty(label))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"{label}: {message}");
                }
            }
        }
    }
}
