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
        // funkcja symulujaca prosty kalkulator przyjmujaca 2 liczby typu double oraz 
        //stringa op ktory wskazuje na operacje jaka ma wykonac funkcja (dodawanie odejmowanie mnozenie dzielenie)
        public static double Arithmetic(double a, double b, string op)
        {
            if (a > 0 && b > 0)
            {
                switch (op)
                {
                    case "add":
                        {
                            return a + b;
                        }
                    case "subtract":
                        {
                            return a - b;
                        }
                    case "multiply":
                        {
                            return a * b;
                        }
                    case "divide":
                        {
                            return a / b;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            return 0;
        }
        //funkcja sumuje wartosc d poszczegolnych liter a=1, b=2 .... z=26 opiera swoje dzialanie na kodzie ascii 
        public static int WordsToMarks(string str)
        {
            var sum = 0;
            int letter = 97;
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    letter = 97;
                    for (int j = 0; j < 27; j++)
                    {
                        if ((int)str[i] == letter)
                        {
                            sum += letter - 96;
                        }
                        letter++;
                    }
                }
                return sum;
            }
            throw new NotImplementedException();
        }
        //funkcja sprawdzajaca czy w podanym wyrazie jako parametr wystepuje taka sama ilosc "x" oraz "o" jesli tak 
        //zwraca true (gdy nie wystepuje ani razu tez) w przeciwnym razie false
        public static bool XO(string input)
        {
            var o = 0;
            var x = 0;

            for(int i=0;i<input.Length;i++)
            {
                if(input[i]=='o' || input[i]=='O')
                {
                    o++;
                }
                if (input[i] == 'x' || input[i]=='X')
                {
                    x++;
                }
            }
            if(o==x || (x==0 && o==0))
            {
                return true;
            }
        return false;
        }
        // funkcja zaokragla wartosc n do 5 np. 
        // TestCase(7, ExpectedResult=10)
        // TestCase(-1, ExpectedResult=0)
         public static int RoundToNext5(int n)
        {
            if (n % 5 == 0)
            {
                return n;
            }
            if (n > 0)
            {
                var rest = n % 5;
                return n + (5 - rest);
            }
            if (n < 0)
            {
                var rest = n % 5;
                return n - rest;
            }
            return 0;
        }
      //funkcja powtarzajaca napis podany jako parametr s podana ilosc razy (parametr n) 
         public static string Repeater(string s, int n)
  {
    var repeat="";
    for(int i=0;i<n;i++)
    {
      repeat+=s;
    }
  return repeat;
  }
        //funkcja zwraca napis pomijajac wszystkie znaki po '#' w podanym porametrze jezeli nie wystepuje '#' zwraca calego stringa
        public static string RemoveUrlAnchor(string url)
        {
            string new_string = "";
            var counter = -1;
            var last = url.LastIndexOf(url);
            for (int i = 0; i < url.Length - 1; i++)
            {
                counter++;
                if (url[i] == '#')
                {
                    new_string = url.Substring(0, counter);
                }
            }
            if (new_string == string.Empty)
            {
                return url;
            }
            return new_string;
        }
        //funkcja sumujaca litery ktore "naleza" do lewej strony lub prawej nastepnie 
        //zachodzi sprawdzenie ktora strona wygrala lewa lub prawa oraz czy wystapil remis 
        public static string AlphabetWar(string fight)
        {
            var left = 0;
            var right = 0;
            for (int i = 0; i < fight.Length; i++)
            {
                switch (fight[i])
                {
                    case 'w':
                        {
                            left += 4;
                            break;
                        }
                    case 'p':
                        {
                            left += 3;
                            break;
                        }
                    case 'b':
                        {
                            left += 2;
                            break;
                        }
                    case 's':
                        {
                            left += 1;
                            break;
                        }
                    case 'm':
                        {
                            right += 4;
                            break;
                        }
                    case 'q':
                        {
                            right += 3;
                            break;
                        }
                    case 'd':
                        {
                            right += 2;
                            break;
                        }
                    case 'z':
                        {
                            right += 1;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            if (left > right)
            {
                return "Left side wins!";
            }
            else if (right > left){
                return "Right side wins!";
            }
            return "Let's fight again!";
        }
}
