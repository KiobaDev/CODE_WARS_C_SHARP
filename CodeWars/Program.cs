using System;

namespace CodeWars
{//Road to junior developer 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("kubaa"));
        }
        //metoda zwracajaca srodkowa litere wprowadzonego paramentu
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
        //metoda konwertujaca inta do stringa
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
        //metoda wypisujaca "Yes" dla parametru word == true w przeciwnym razie wypisuje "No" dla false
        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
                return "No";
        }
        //metoda sprawdzajaca czy z podanych parametrow mozliwe jest zbudowanie trojakta jesli tak zwraca true w przeciwnym wypadku false
        public static bool IsTriangle(int a, int b, int c)
        {
            var half = (a + b + c) / 2;
            var square = Math.Sqrt(half * (half - a) * (half - b) * (half - c));
            if (square <= 0)
            {
                return false;
            }
            else if (a + b < c || a + c < b || b + c < a)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //metoda wypisujaca napis "Found the needle at position" oraz index w tablicy danego napisu 
        public static string FindNeedle(object[] haystack)
        {
            string no = "empty";
            string msg;
            var index = -1;
            foreach (var item in haystack)
            {
                index++;
                if (item == "needle")
                {
                    msg = ("found the needle at position " + index).ToString();
                    return msg;
                }
            }
            return no;
        }
        //metoda dzialajaca jak podstawowy kalkulator - wybor dzialania jest dokonywany przez parametr "operation"
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    {
                        return value1 + value2;
                    }
                case '-':
                    {
                        return value1 - value2;
                    }
                case '*':
                    {
                        return value1 * value2;
                    }
                case '/':
                    {
                        return value1 / value2;
                    }
            }
            return 0;
        }
        //metoda odwracajaca stringa str podanego jako parametr oraz zwracajaca wynik odwrocenia pod zmienna reverse
        public static class Kata
        {
            public static string Solution(string str)
            {
                var reverse = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }
                return reverse;
                throw new NotImplementedException("TODO: Kata.Solution(string) => string");
            }
            //druga wersja uzywajaca LINQ
            public static string Solution(string str)
            {
              return new string(str.Reverse().ToArray());
            }
            // metoda zwracajaca sume liczb z przedzialu podanego jako parametr od = 0 do 
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
            //metoda sprawdzajaca czy suma elementow tablicy jest parzysta lub nieparzysta
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
            //metoda konwertuje sume parametrow a i b na kod binarny
            public static string AddBinary(int a, int b)
            {
                var sum = Convert.ToString(a + b, 2);
                return sum;
            }
        }
        //metoda sortujaca elementy tablicy (wyrazy) po ich dlugosci 
        public static string[] SortByLength(string[] array)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].Length - 1 > array[j + 1].Length - 1)
                    {
                        var tmp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }
        //metoda odwracajaca stringa z pominieciem znakow ktore nie znajduja siew alfabecie
        public string ReverseLetter(string str)
        {
            var rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    rev += str[i];
                }
            }
            return rev;
        }
        //metoda sumuje 2 najmniejsze liczby w tablicy i zwraca ich wartosc
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            var l = numbers.Length - 1;
            return numbers[l] + numbers[l - 1];
        }
        //metoda zwraca liczbe dzielnikow liczy podanej jako parametr funkcji
        public static int Divisors(int n)
        {
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }
            return counter;
        }
        //metoda symulujaca prosty kalkulator przyjmujaca 2 liczby typu double oraz 
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
        //metoda sumuje wartosc d poszczegolnych liter a=1, b=2 .... z=26 opiera swoje dzialanie na kodzie ascii 
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
        //metoda sprawdzajaca czy w podanym wyrazie jako parametr wystepuje taka sama ilosc "x" oraz "o" jesli tak 
        //zwraca true (gdy nie wystepuje ani razu tez) w przeciwnym razie false
        public static bool XO(string input)
        {
            var o = 0;
            var x = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'o' || input[i] == 'O')
                {
                    o++;
                }
                if (input[i] == 'x' || input[i] == 'X')
                {
                    x++;
                }
            }
            if (o == x || (x == 0 && o == 0))
            {
                return true;
            }
            return false;
        }
        // metoda zaokragla wartosc n do 5 np. 
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
        //metoda powtarzajaca napis podany jako parametr s podana ilosc razy (parametr n) 
        public static string Repeater(string s, int n)
        {
            var repeat = "";
            for (int i = 0; i < n; i++)
            {
                repeat += s;
            }
            return repeat;
        }
        //metoda zwraca napis pomijajac wszystkie znaki po '#' w podanym porametrze jezeli nie wystepuje '#' zwraca calego stringa
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
        //metoda sumujaca litery ktore "naleza" do lewej strony lub prawej nastepnie 
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
            else if (right > left)
            {
                return "Right side wins!";
            }
                return "Let's fight again!";
        }
        //metoda zwracajaca pozycje liter w parametrze ktore sa duza litera alfabetu
        public static int[] Capitals(string word)
        {
            List<int> tab = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] > 64 && word[i] < 91)
                {
                    tab.Add(i);
                }
            }
            return tab.ToArray();
        }
        //metoda zwracajaca ciag znakow w postaci np. A-Bb-Ccc... kazda litera 
        //jest wypisana o 1 wiecej niz poprzednai w stringu oraz gdy wystepuje 1 raz jest napisana z duzej litery gdy nastepuje zmiana litery zostaje dodany znak "-"
        public static String Accum(string s)
        {
            int counter = -1;
            var word = "";
            for (int i = 0; i < s.Length; i++)
            {
                counter++;
                for (int j = 0; j <= counter; j++)
                {
                    if (j == 0)
                    {
                        word += s[i].ToString().ToUpper();
                    }
                    else if (s[i] != counter)
                    {
                        word += s[i].ToString().ToLower();
                    }
                }
                if (i != s.Length - 1)
                {
                    word += "-";
                }
            }
            return word.ToString();
        }
        //metoda
        public static bool PowerOfTwo(int n)
        {
            var x = 0;
            var y = 2;
            if (n == 0)
            {
                return false;
            }
            for (int i = 0; i <= y; i++)
            {
                y *= 2;
                x++;
                if (n % Math.Pow(2, x) == 0 || n == 1)
                {
                    return true;
                }
            }
            return false;
        }
        //metoda znajduje w tablicy liczbe wystepujaca nieparzysta liczbe razy (zawsze jest to 1 cyfra) oraz ja zwraca
        public static int find_it(int[] seq)
        {
            var counter = 0;
            foreach (var item in seq)
            {
                counter = 0;
                for (int i = 0; i < seq.Length; i++)
                {
                    if (seq[i] == item)
                    {
                        counter++;
                    }
                }
                if (counter % 2 == 1)
                {
                    return item;
                }
            }
            return -1;
        }
        //metoda sortujaca liczby w tablicy jesli tablica jest pusta zwraca pusta tablice
        public static int[] SortNumbers(int[] nums)
        {
            if (nums != null)
            {
                Array.Sort(nums);
                return nums;
            }
            var emp = Array.Empty<int>();
            return emp;
        }
        //metoda usuwajaca ze stringa znaki inne niz (a-z oraz A-Z) po kazdym usunieciu takiego znaku nastepny znak to duza litera.
        public static string ToCamelCase(string str)
        {
            var newstr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] > 64 && str[i] < 91 || str[i] > 96 && str[i] < 123)
                {
                    newstr += str[i];
                }
                else
                {
                    newstr += str[i + 1].ToString().ToUpper();
                    i++;
                }
            }
            return newstr;
        }
   
    //metoda sprawdzajaca czy spacer zakonczy sie w miejscu wyjscia litery n s w e reprezentuja 
    //kierunki kazda iteracja to 1 krok w danym kierunku spacer ma zajac 10 minut kazda iteracja pojedynczego kierunku to 1 minuta
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length == 10)
        {
            var n = walk.Count(x => x.Contains("n"));
            var s = walk.Count(x => x.Contains("s"));
            var w = walk.Count(x => x.Contains("w"));
            var e = walk.Count(x => x.Contains("e"));
            if (n != s || w != e)
            {
                return false;
            }
        }
        else
        {
            return false;
        }
            return true;
    }
    //metoda zamieniajaca litery z parametru na liczby wedlug zasady a=1,b=2 ...  jesli wprowadzona jest duza litera posiada ta sama wartosc co mala 
    // metoda zwraca nowy lancuch na zasadzie "1 15 12 5 3 2 1"
    public static string AlphabetPosition(string text)
    {
        string alphabetSmall = "abcdefghijklmnopqrstuvwxyz";
        string alphabetBig = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        string newstr = "";
        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j <= alphabetSmall.Length - 1; j++)
            {
                if (text[i] == alphabetSmall[j] || text[i] == alphabetBig[j])
                {
                    newstr += j + 1 + " ";
                }
            }
        }
        text = "";
        for (int x = 0; x < newstr.Length - 1; x++)
        {
            text += newstr[x];
        }
        return text;
    }
    //metoda ktora sortuje w tablicy liczby ktore sa nieparzyste rosnaco natomiast gdy w tablicy 
    //jest liczba parzysta zostawia ja bez zmiany metoda zwraca nowa posortowana tablice 
    public static int[] SortArray(int[] array)
    {
        var z = 0;
        int[] tab = new int[array.Length];
        var x = array.Where(q => q % 2 == 1).OrderBy(y => y).ToArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                tab[i] = array[i];
            }
            else
            {
                tab[i] = x[z];
                z++;
            }
        }
        return tab;
    }
    //metoda dodajaca do 1 do liczby tworzonej przez poszczegolne elementy tablicy np dla 239 zostaje zwrocona wartosc 240 a dla 240 zwrocono 241
    public static int[] UpArray(int[] num)
        {
            if(num[i==9])
            if (num.Count() == 0)
            {
                return null;
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {
                if (num.Sum() == 0)
                {
                    num[0]+=1;
                }
                    if (num[i] > 9)
                {
                    return null;
                }
                if (i == num.Length - 1 && num[i] < 9 && num[i] >= 0)
                {
                    num[i] += 1;
                }
                else if (num[i] == 9 && i > 0)
                {
                    num[i] = 0;
                    num[i - 1] += 1;
                }
                else if (num[i] < 0)
                {
                    return null;
                }
            }
            return num;
        }
        //metoda zwracajaca sume kwadratu wszystkich elementow tablicy
         public static int SquareSum(int[] n)
        {
            int result = 0;
            var x = from a in n select Math.Pow(a,2);
               foreach(var item in x)
                {
                result += (int)item;
                }      
          return result;
        }
        //metoda ustawiajaca wszystkie 0 na koncu tablicy a inne liczby/cyfry pozostawia na swoich miejscach bez zmian [5kyu]
        public static int[] MoveZeroes(int[] arr)
        {
            var i = 0;
            int[] newarr = new int[arr.Length];
            var x = from a in arr where a == 0 orderby a descending select a;
            foreach(var item in arr)
            {
                if (item != 0)
                {
                    newarr[i] = item;
                    i++;
                }
            }
            foreach (var item in x)
            {
                newarr[i] = item;
                i++;
            }
            return newarr;
        }
        //metoda zamnieniajca liczby dodatnie na ujemne
        public static int[] InvertValues(int[] input)
        {
            for(int i = 0; i < input.Length; i++)
            {
                input[i] = -input[i];
            }
            return input;
        }
        //metoda sprawdzajaca czy wszystkie litery 2 parametru znajduja sie w 1 jesli tak zwraca true inaczej falase [5kyu]
        public static bool Scramble(string str1, string str2)
        {
            var result = str2.Where(x => str1.Contains(x));
            if (result.Count() == str2.Length)
            {
                return true;
            }
            return false;
        }
        //metoda dzielaca stringi po n-elementow np thisisstring -> dla n=4 zwraca this \n isst \n ring (dla ostatniego indeksu nie zachodzi dopisanie znaku nowej lini)
        public static string StringBreakers(int n, string str)
        {
            string tmp = "";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                   tmp += str[i];
                }
            }
            str = "";
            for(int j = tmp.Length; j > 0; j -= n)
            {
                if (tmp.Length >= n)
                {
                    str += tmp.Substring(0, n);
                    if (n != tmp.Length)
                    {
                        str += "\n";
                        tmp = tmp.Remove(0, n);
                    }
                }
                else
                {
                    str += tmp;
                }
            }
            return str;
        }
        //metoda konwertujaca sekundy na format HH:MM:SS (godziny:minuty:sekundy) gdzie mas=ksymalna godzina moze byc 99:59:59 (5 kyu - do pozniejszej refaktoryzacji)
        public static string GetReadableTime(int seconds)
        {
            if(seconds<= 359999)
            {
                int tmp = 0;
                string newStr = "";
                //HOURS
                while (seconds / 3600 != 0)
                {
                    seconds -= 3600;
                    tmp++;

                }
                if (tmp < 10)
                {
                    newStr += "0" + tmp + ":";
                }
                else
                {
                    newStr += (tmp) + ":";
                }
                tmp = 0;
                    //MINUTES
                    while (seconds / 60 != 0)
                    {
                        seconds -= 60;
                        tmp++;
                    }
                    if (tmp < 10)
                    {
                         newStr += "0" + tmp + ":";
                    }
                    else
                    {
                        newStr += (tmp) + ":";
                    }
                    tmp = 0;
                        //SECONDS
                        while (seconds / 1 != 0)
                        {
                            seconds -= 1;
                            tmp++;
                        }
                        if (tmp < 10)
                        {
                            newStr += "0" + tmp;
                        }
                        else
                        {
                            newStr += (tmp) + ":";
                        }
            return newStr;
            }
            return null;
        }
        //metoda sprawdzajaca ile lat potrzeba do osiagniecia wskazanej populacji np w miescie 
        //p0 - poczatkowa populacja percent - procent roczny nowych osob aug - liczba nowych/odchodzacych osob - p populacja ktora ma zostac osiagnieta
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years = 0;
            double _p0 = Convert.ToDouble(p0);

            while (_p0 < p)
            {
                _p0 += (int)(_p0 * percent / 100) + aug;
                years++;
                Console.WriteLine(years + "   " + _p0);
            }
            return years;
        }
        //metoda znajdujaca maksymalny ciag ktory znajduje sie w podtablicy
        public static int MaxSequence(int[] arr)
    {
        int max = 0, res = 0, sum = 0;
        foreach(var item in arr)
        {
            sum += item;
            max = sum > max ? max : sum;
            res = res > sum - max ? res : sum - max;
        }
        return res;
    }
}
    //Alphabet war - Wo lo loooooo priests join the war - nazwa zadania -> czytaj wiecej na codewars.com
    // metoda sprawdzajaca ktora strona (lewa czy prawa) wygrywa litery i ich wartosci : lewe  w - 4 p - 3 b - 2s - 1  t - 0 (but it's priest with Wo lo loooooooo power) 
    //prawa:  m - 4 q - 3  d - 2 z - 1 j - 0 (but it's priest with Wo lo loooooooo power)
  public static string AlphabetWar(string fight)
    {
        string power = "wpbs_zdqm";
        fight = new Regex(@"(?<!t)[wpbs](?=j)|(?<=j)[wpbs](?!t)|(?<!j)[zdqm](?=t)|(?<=t)[zdqm](?!j)").Replace(fight, x => ""+ power[8 - power.IndexOf(x.Value)]);
        int result = fight.Aggregate(0, (a, b) => a + (power.IndexOf(b) == -1 ? 0 : power.IndexOf(b) - 4)); //
        return result == 0 ? "Let's fight again!" : $"{(result < 0 ? "Left":"Right")} side wins!";
    }
//
public class SumDigPower {

    public static long[] SumDigPow(long a, long b)
    {
        List<long> values = new List<long>();
        for (long x = a; x <= b; x++)
        {
          if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
            values.Add(x);
        }
        return values.ToArray();
    }
}
    //metoda zwracaja pierwszy najdluzszy lancuch skladajacy sie z k kolejnych ciagow w tablicy 
    public class LongestConsecutives {
    public static string LongestConsec(string[] s, int k){
        return s.Length==0||s.Length<k||k<=0 ? ""
             : Enumerable.Range(0,s.Length-k+1)
                         .Select(x=>string.Join("",s.Skip(x).Take(k)))
                         .OrderByDescending(x=>x.Length)
                         .First();
    }
        public static class Kata
{
  //metoda symulujaca dzialanie systemu lajkowania na Facebooku
  public static string Likes(string[] names)
  {
    switch (names.Length)
    {
      case 0: return "no one likes this"; // :(
      case 1: return $"{names[0]} likes this";
      case 2: return $"{names[0]} and {names[1]} like this";
      case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
      default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
    }
  }
}
        //metoda zwracajaca silnie podanej liczby w parametrze liczba musi byc wieksza od 0 ale mniejsza od 12
        public static int Factorial(int n)
        {
            int resume = 1;
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException();
            }
            while (n>=0)
            {
                if (n == 0)
                {
                    resume *= 1;
                }
                else
                {
                    resume *= n;
                }
                n--;
            }
            return resume;
        }
        //
        //metoda znajdujaca wszystkie księgi L z kodami należącymi do każdej kategorii M i zsumować ich ilość według każdej kategorii

    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter) {
        if (lstOfArt.Length == 0) {
            return "";
        }
        string result = "";
        foreach (string m in lstOf1stLetter) {
            int tot = 0;
            foreach (string l in lstOfArt) {
                if (l[0] == m[0]) {
                    tot += int.Parse(l.Split(' ')[1]);
                }
            }
            if (!String.IsNullOrEmpty(result)) {
                result += " - ";
            }
            result += "(" + m + " : " + tot + ")";
        }
        return result;
    }
        //zadanie rekrutacyjne znalezione na jednej z grup FB Opis: funkcja ma wypisac na ekran kat pomiedzy wskazowka godzinowa a minutowa w zegarze
        public static void angle()
        {
            Console.WriteLine("Type a hour");
            string _hour = Console.ReadLine();
            int hour;
            Console.WriteLine("Type a minute");
            string _minute = Console.ReadLine();
            int minute;
            bool isTrueMinute = int.TryParse(_minute, out minute);
            bool isTrueHour = int.TryParse(_hour, out hour);
            if (isTrueHour==true && hour <= 12 && isTrueMinute==true && minute <= 59 && minute>0 && hour>0)
            {
                Console.WriteLine("Angle equals: " + ((hour*60)/2 - minute));
            }
            else
            {
                Console.WriteLine("Inncorect HOUR/MINUTE!");
            }
        }
  //metoda zwracaja imie i nazwisko (jesli ktoras wartosc jest pusta lub tez ma wartosc null zwraca tylko druga)
  private string firstName;
  private string lastName;
  public string FullName
  {
    get
    {
      if(string.IsNullOrEmpty(firstName))
        {
          return lastName;
        }
      if(string.IsNullOrEmpty(lastName))
        {
          return firstName;
        }
          return firstName+" "+lastName;
    }
  }
  
  public Dinglemouse(string firstName, string lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
  }
        //metoda konwertujaca parzyste liczby/cyfry na kod binarny - nieparzysta na kod hexadecymalny
        public static string EvensAndOdds(int num)
        {
            if (num % 2 == 0)
            {
                var binary = Convert.ToString(num, 2);
                return binary.ToLower();
            }
            string Hex = num.ToString("X");
            return Hex.ToLower();
        }
        //metoda sprawdzajaca czy bohater zabral wystarczajaca liczbe pociskow aby zabic wszystkie atakujace smoki 
        //(Kazdy smok wymaga 2 pociskow) jesli tak zwracana jest wartosc true w przeciwnym wypadku false 
        public static bool Hero(int bullets, int dragons)
        {
            if (dragons * 2 <= bullets)
            {
                return true;
            }
            return false;
        }
       //metoda zwracajaca przypisana do przedzialu litere na podstawie sredniej z 3 liczb wszystkie liczby sa dodatnie i mniejsze badz rowne 100 
          public static char GetGrade(int s1, int s2, int s3)
        {
            var score = (s1 + s2 + s3) / 3;
            if(90 <= score && score <= 100)
            {
                return 'A';
            }
            else if (80 <= score && score < 90)
            {
                return 'B';
            }
            else if (70 <= score && score < 80)
            {
                return 'C';
            }
            else if (60 <= score && score < 70)
            {
                return 'D';
            }
            return 'F';
        }
        //metoda zwracajaca roznice wymnozonych przez siebie elementow tablic a i b 
        public static int FindDifference(int[] a, int[] b)
        {
            int resultA = 1;
            int resultB = 1;
            for(int i = 0; i < a.Length; i++)
            {
                resultA *= a[i];
                resultB *= b[i];
            }
            if (resultA > resultB)
            {
                return resultA - resultB;
            }
            return resultB - resultA;
        }
}
