using System;
using System.Globalization;

namespace TransformToWords
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public static class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public static string TransformToWords(double number)
        {
            string numberT = new string(number.ToString(CultureInfo.InvariantCulture));
            string convertNumber = string.Empty;
            if (number is double.NaN)
            {
                return number.ToString(CultureInfo.InvariantCulture);
            }
            else if (number == double.PositiveInfinity)
            {
                return "Positive Infinity";
            }
            else if (number == double.NegativeInfinity)
            {
                return "Negative Infinity";
            }
            else if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }
            else
            {
                if (numberT[0] == '-')
                {
                    convertNumber = "Minus";
                }
                else if (numberT[0] == '0')
                {
                    convertNumber = "Zero";
                }
                else if (numberT[0] == '1')
                {
                    convertNumber = "One";
                }
                else if (numberT[0] == '2')
                {
                    convertNumber = "Two";
                }
                else if (numberT[0] == '3')
                {
                    convertNumber = "Three";
                }
                else if (numberT[0] == '4')
                {
                    convertNumber = "Four";
                }
                else if (numberT[0] == '5')
                {
                    convertNumber = "Five";
                }
                else if (numberT[0] == '6')
                {
                    convertNumber = "Six";
                }
                else if (numberT[0] == '7')
                {
                    convertNumber = "Seven";
                }
                else if (numberT[0] == '8')
                {
                    convertNumber = "Eight";
                }
                else if (numberT[0] == '9')
                {
                    convertNumber = "Nine";
                }

                for (int i = 1; i < numberT.Length; i++)
                {
                    if (numberT[i] == '-')
                    {
                        convertNumber = string.Empty + convertNumber + " minus";
                    }
                    else if (numberT[i] == '+')
                    {
                        convertNumber = string.Empty + convertNumber + " plus";
                    }
                    else if (numberT[i] == '0')
                    {
                        convertNumber = string.Empty + convertNumber + " zero";
                    }
                    else if (numberT[i] == '1')
                    {
                        convertNumber = string.Empty + convertNumber + " one";
                    }
                    else if (numberT[i] == '2')
                    {
                        convertNumber = string.Empty + convertNumber + " two";
                    }
                    else if (numberT[i] == '3')
                    {
                        convertNumber = string.Empty + convertNumber + " three";
                    }
                    else if (numberT[i] == '4')
                    {
                        convertNumber = string.Empty + convertNumber + " four";
                    }
                    else if (numberT[i] == '5')
                    {
                        convertNumber = string.Empty + convertNumber + " five";
                    }
                    else if (numberT[i] == '6')
                    {
                        convertNumber = string.Empty + convertNumber + " six";
                    }
                    else if (numberT[i] == '7')
                    {
                        convertNumber = string.Empty + convertNumber + " seven";
                    }
                    else if (numberT[i] == '8')
                    {
                        convertNumber = string.Empty + convertNumber + " eight";
                    }
                    else if (numberT[i] == '9')
                    {
                        convertNumber = string.Empty + convertNumber + " nine";
                    }
                    else if (numberT[i] == '.')
                    {
                        convertNumber = string.Empty + convertNumber + " point";
                    }
                    else if (numberT[i] == 'E')
                    {
                        convertNumber = string.Empty + convertNumber + " E";
                    }
                }

                return convertNumber;
            }
        }
    }
}
