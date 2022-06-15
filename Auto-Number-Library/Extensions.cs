using System;

namespace NetFramework.Library
{
    public static class Extensions
    {
        private static readonly char[] intArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        public static string Reverse(this string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string Add(this string givenString, int add)
        {
            int lastIndexOf = givenString.LastIndexOfAny(intArray);

            if (lastIndexOf >= 0)
            {
                int firstIndexOf = lastIndexOf;
                string numericString = "";
                while (char.IsDigit(givenString[firstIndexOf]))
                {
                    numericString += givenString[firstIndexOf];
                    firstIndexOf--;
                }

                int num = int.Parse(numericString.Reverse()) + add;
                int numLength = lastIndexOf - firstIndexOf;

                string returnVal = givenString.Substring(0, firstIndexOf + 1) + num.ToString($"D{numLength}") +
                    givenString.Substring(lastIndexOf + 1);

                return returnVal;
            }

            return default;
        }
    }
}