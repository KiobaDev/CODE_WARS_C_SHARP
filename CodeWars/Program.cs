using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("kubaa"));
        }
        //funkcja wypisujaca srodkowa litere wyrazu
        public static string GetMiddle(string s)
        {
            int x = s.Length / 2;
            string str = "";
            if (s.Length % 2 == 0)
            {
                str += s[x - 1];
                str += s[x];
                return str;
            }
            else
                str += s[x];
            return str;
        }
        //funkcja konwertujaca inta do stringa
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
        // funkcja wypisujaca "Yes" dla parametru word == true w przeciwnym razie wypisuje "No" dla false
        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
                return "No";
        }
        //Funkcja sprawdzajaca czy z podanych parametrow mozliwe jest zbudowanie trojakta jesli tak zwraca true
        public static bool IsTriangle(int a, int b, int c)
        {
            var half = (a + b + c) / 2;
            var square = Math.Sqrt(half * (half - a) * (half - b) * (half - c));
            if (a+b>c|| a+c>b || b+c>a && square > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
      }
    }
}
