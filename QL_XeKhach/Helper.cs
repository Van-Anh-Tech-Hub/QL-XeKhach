using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace QL_XeKhach
{
    public class Helper
    {
        private static string logFilePath = "error_log.txt";
        private static Random random = new Random();
        public static string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }

            return result.ToString();
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        public static void ShowMessage(string message, string title = "Notification", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            MessageBox.Show(message, title, buttons, icon);
        }

        public static void LogError(Exception ex)
        {
            using (var writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] Error: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine();
            }

            MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
