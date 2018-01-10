namespace _2048.Extensions
{
    public static class StringExtensions
    {
        public static string CenterPad (this string stringToPad, int lengthToPadTo)
        {
            int spaces = lengthToPadTo - stringToPad.Length;
            int padLeft = spaces / 2 + stringToPad.Length + 1;
            return stringToPad.PadLeft(padLeft).PadRight(lengthToPadTo);
        }
    }
}
