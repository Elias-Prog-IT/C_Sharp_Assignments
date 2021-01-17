/*
	@Author Elias Posluk
    Course: DA562B, Fundamental Programming in C#
	@date 2017-12-17
	Assignment_6_CaesarCipher
	Kristianstad University
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4.CaesarCipher
{
    class Program
    {
        static class CaesarCipher
        {
            //utskrivbara tecken
            static char[] printableAsciiCharacter =
            {
            '!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0','1','2','3','4','5','6','7','8','9',
             ':',';','<','=','>','?','@','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R',
            'S','T','U','V','W','X','Y','Z','[','\\',']','^','_','`','a','b','c','d','e','f','g','h','i','j','k',
            'l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','{','|','}','~'
            };

            public static string Encode(string textToEncode)
            {
                string result = "";

                //Konverterar sträng till char-array
                char[] buffer = textToEncode.ToCharArray();

                for (int i = 0; i < buffer.Length; i++)
                {
                    //hämtar bokstäverna
                    char letter = buffer[i];
                    int index = Array.IndexOf(printableAsciiCharacter, letter);

                    //Ersätter den givna charaktären med en annan som är placerad 4 platser längre ner i alfabetet
                    index = index - 4;
                    // subtraherar 97 om "overflow".
                    if (index > 93)
                    {
                        index = (index - 94);
                    }
                    //adderar istället 94 om "underflow".
                    else if (index < 0)
                    {
                        index = (index + 94);
                    }
                    //Sparar in den nya chiffrerade bokstaven
                    buffer[i] = printableAsciiCharacter[index];
                }

                //Konverterar tillbaka från char-array till sträng-array
                result =  new string(buffer);
                return result;
            }

            public static string Decode(string textToEncode)
            {
                string result = "";

                //Konverterar från sträng till char-array
                char[] buffer = textToEncode.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    //Hämtar bokstav
                    char letter = buffer[i];
                    int index = Array.IndexOf(printableAsciiCharacter, letter);
                    //ersätter den givna charaktären med bokstaven som är fyra platser upp i alfabetet
                    index = index + 4;
                    //subtraherar 26 på "overflow"
                    if (index > 93)
                    {
                        index = (index - 94);
                    }
                    // adderar 26
                    else if (index < 0)
                    {
                        index = (index + 94);
                    }
                    
                    //sparar in den avkodade bokstaven
                    buffer[i] = printableAsciiCharacter[index];
                }

                //Konverterar tillbaka från char-array till sträng-array 
                result = new string(buffer);
                return result;
            }

        }

        static void Main(string[] args)
        {
            //Hämtar in text från user-input, som ska chiffreras/encodas
            Console.Write("Please enter text to encode: ");
            string input = Console.ReadLine();

            //encodar/kodar
            string encodedText = CaesarCipher.Encode(input);
            Console.WriteLine("\nText encoded to: " + encodedText);

            //decode/avkodar
            string decodedText = CaesarCipher.Decode(encodedText);
            Console.WriteLine("\nYour initial text is: "+decodedText);

            //programmets avslut
            Console.WriteLine("\n\nPress any key to quit...");
            Console.ReadKey();
        }
    }
}
