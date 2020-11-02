using System;
using System.Text;

namespace TU_homework
{
    public class _﻿CaesarCipher
    {
        /// <summary>
        /// Returns encrypted text
        /// </summary>
        /// <param name="text">Text that will be encrypted</param>
        /// <param name="shift">Shift used to encrypt</param>
        /// <returns>Encrypted text</returns>
        public string encryptText(string text, int shift)
        {
            StringBuilder encryptedText = new StringBuilder();
            //Changes shift value if current value is negative
            shift = shift >= 0 ? shift : (26-Math.Abs(shift % 26));
            char shiftedLetter;
            foreach(char letter in text)
            {
                if(char.IsLetter(letter))
                {
                    //Using to determine if letter is capital or small
                    char startIndex = char.IsUpper(letter) ? 'A' : 'a';
                    //Using ASCII. shifted_letter = ((letter_code + shift) - start_index) mod (alphabet_lenght) + start_index
                    shiftedLetter = (char)(((letter + shift) - startIndex) % 26 + startIndex);
                }
                else
                {
                    shiftedLetter = letter;
                }
                encryptedText.Append(shiftedLetter);
            }
            return encryptedText.ToString();
        }

        /// <summary>
        /// Returns decrypted text
        /// </summary>
        /// <param name="text">Text that will be decrypted</param>
        /// <param name="shift">Shift used to decrypt</param>
        /// <returns>Decrypted text</returns>
        public string decryptText(string text, int shift)
        {
            return encryptText(text, 26 - shift);
        }
    }
}
