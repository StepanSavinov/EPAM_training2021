using System;

namespace epam_xt
{
    class CustomString
    {
        private char[] _charsString;

        public int Length { get; }

        public CustomString() : this("") {}

        public CustomString(char[] chars)
        {
            Length = chars.Length;
            _charsString = new char[Length];

            Array.Copy(chars, _charsString, Length);
        }

        public CustomString(string str)
        {
            Length = str.Length;
            _charsString = str.ToCharArray();
        }

        public char this[int index] { get => _charsString[index]; set => _charsString[index] = value; }

        public override string ToString() => new string(_charsString);
        
        public char[] ToCharArray()
        {
            char[] temp = new char[Length];
            Array.Copy(_charsString, temp, Length);

            return _charsString;
        }

        public int IndexOfChar(char c, int startIndex) => Array.FindIndex(_charsString, startIndex, index => index == c);

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
