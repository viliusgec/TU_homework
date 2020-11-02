# TransUnion homework for internship - Caesar cipher

## About
TransUnion Internship task\
Developed by Vilius Gečas\
Project is developed using C# .Net\
Caesar cipher – shifts every letter in text by fixed number

## Manual
- Run program
- Enter integer (can be both positive or negative)
- Enter text you want to encrypt
- You will get encrypted and decrypted texts

## How it works
Using ASCII.\
Shifting every letter separately using formula:\
shifted_letter = ((letter_code + shift) - start_index) mod (alphabet_lenght) + start_index
- start_index – is either 65 (if letter is capital) or 97 (if letter is small)
- for example using shift 2, "ABC" encrypted will become "CDE"
## Testing
Unit testing was done using MSTest. 
- Tested both positive and negative integers (shift)
- Tested short and long sentences with symbols and numbers
- Every test was successful with both encryption and decryption
