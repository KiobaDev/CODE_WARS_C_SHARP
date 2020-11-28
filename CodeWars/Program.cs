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
        //Funkcja sprawdzajaca czy z podanych parametrow mozliwe jest zbudowanie trojakta jesli tak zwraca true w przeciwnym wypadku false
        public static bool IsTriangle(int a, int b, int c)
        {
            var half = (a + b + c) / 2;
            var square = Math.Sqrt(half * (half - a) * (half - b) * (half - c));
            if(square<=0)
            {
                return false;
            }
            else if(a+b<c || a+c<b || b + c < a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //funkcja wypisujaca napis "Found the needle at position" oraz index w tablicy danego napisu 
        public static string FindNeedle(object[] haystack)
        {
            string no="empty";
            string msg;
            var index=-1;
            foreach(var item in haystack)
            {
                index++;
                if(item=="needle")
                {
                    msg = ("found the needle at position " + index).ToString();
                    return msg;
                }
            }
            return no;
        }
        //funkcja dzialajaca jak podstawowy kalkulator - wybor dzialania jest dokonywany przez parametr "operation"
        public static double basicOp(char operation, double value1, double value2)
    {
     switch(operation)
     {
       case '+':
         {
          return value1+value2;
         }
        case '-':
         {
          return value1-value2;
         }
        case '*':
         {
          return value1*value2;
         }
        case '/':
         {
          return value1/value2;
         }
      }
      return 0;
    }
        //funkcja odwracajaca stringa str podanego jako parametr oraz zwracajaca wynik odwrocenia pod zmienna reverse
        public static class Kata
{
  public static string Solution(string str)
    {
      var reverse = "";
      for (int i=str.Length-1;i>=0;i--)
      {
       reverse +=str[i];
      }
      return reverse;
      throw new NotImplementedException("TODO: Kata.Solution(string) => string");
    }
            // funkcja zwracajaca sume liczb z przedzialu podanego jako parametr od = 0 do 
            //podanej liczby jesli podano 0 zwracana wartosc to 0 przykladowo summation(8) zwraca wartosc 36
             public static int summation(int num)
        {
            var number = 0;
            if (num > 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    number += i;
                }
                return number;
            }
            else
            {
                return 0;
            }
        }
            //funkcja sprawdzajaca czy suma elementow tablicy jest parzysta lub nieparzysta
            public static string OddOrEven(int[] array)
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if (sum % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
            //funkcja convertuje sume parametrow a i b na kod binarny
            public static string AddBinary(int a, int b)
  {
      var sum = Convert.ToString(a+b,2);
    return sum;
  }
    }
        //funkcja sortujaca elementy tablicy (wyrazy) po ich dlugosci 
        public static string[] SortByLength(string[] array)
        {
            for(int i=0;i<=array.Length;i++)
            {
                for(int j = 0; j < array.Length-1; j++)
                {
                    if (array[j].Length-1 > array[j + 1].Length-1)
                    {
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
        //funkcja odwracajaca stringa z pominieciem znakow ktore nie znajduja siew alfabecie
        public string ReverseLetter(string str)
        {
            var rev = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                if(str[i]>='a' && str[i] <= 'z')
                {
                    rev += str[i];
                }
            }
            return rev;
        }
        // funkcja sumuje 2 najmniejsze liczby w tablicy i zwraca ich wartosc
         public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            var l = numbers.Length-1;
            return numbers[l] + numbers[l - 1];
        }
        //zwraca liczbe dzielnikow liczy podanej jako parametr funkcji
        public static int Divisors(int n)
        {
            int counter = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
}
