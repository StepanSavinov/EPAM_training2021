using System;

namespace epam_xt
{
    class CustomString
    {
        private char[] CharsString;

        public int Length { get; }

        public CustomString() : this("") {}

        public CustomString(char[] chars)
        {
            Length = chars.Length;
            CharsString = new char[Length];

            Array.Copy(chars, CharsString, Length);
        }

        public CustomString(string str)
        {
            Length = str.Length;
            CharsString = str.ToCharArray();
        }

        public char this[int index] { get => CharsString[index]; set => CharsString[index] = value; }

        public override string ToString() => new string(CharsString);
        
        public char[] ToCharArray()
        {
            char[] temp = new char[Length];
            Array.Copy(CharsString, temp, Length);

            return CharsString;
        }

        public int IndexOfChar(char c, int startIndex) => Array.FindIndex(CharsString, startIndex, index => index == c);

        public int IndexOfChar(char c) => IndexOfChar(c, 0);

        public bool Contains(char c) => IndexOfChar(c) != -1;
        
        public static int CompareTo(CustomString str1, CustomString str2)
        {
            if (str1.Length > str2.Length) { return 1; }

            else if (str2.Length > str1.Length) { return -1; }

            else return 0;
        }

        public static CustomString Concatenate(CustomString str, CustomString str2)
        {
            char[] toChar = str2.ToCharArray();

            char[] temp = new char[str.Length + toChar.Length];

            Array.Copy(str.ToCharArray(), temp, str.Length);
            Array.Copy(toChar, 0, temp, str.Length, toChar.Length);

            return new CustomString(temp);
        }
    }
}
