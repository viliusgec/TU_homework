using System;

namespace TU_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int shift = getShift();
            string text = getText();
            _CaesarCipher cipher = new _CaesarCipher();
            string encryptedText = cipher.encryptText(text, shift);
            string decryptedText = cipher.decryptText(encryptedText, shift);
            Console.WriteLine($"Encrypted text: {encryptedText}");
            Console.WriteLine($"Decypted text: {decryptedText}");
        }

        public static int getShift()
        {
            Console.Write("Enter shift: ");
            int shift;
            while (true)
            {
                try
                {
                    shift = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Shift must be an integer number.");
                    Console.Write("Please enter shift again: ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number cannot fit in an Int32.");
                }
            }
            return shift;
        }

        public static string getText()
        {
            string text = null;
            while (string.IsNullOrEmpty(text))
            {
                Console.Write("Enter text: ");
                text = Console.ReadLine();
            }
            return text;
        }
    }
}
