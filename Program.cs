using System.Text;
using System.Text.RegularExpressions;

namespace CoderHub;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(oct_to_bin(5252));
        Console.WriteLine(oct_to_bin(777));
        Console.WriteLine(oct_to_bin(123));
        Console.WriteLine(oct_to_bin(6523));
        Console.ReadLine();
    }


    #region EasyProblems
    private static int[] remove_duplicate(int[] arr)
    {
        // write your code here

        int counter = 0;
        int[] res = new int[arr.Length];

        foreach (var i in arr)
        {
            var temp = Array.FindAll(arr, element => element == i);

            if (temp.Length == 1)
            {
                res[counter] = i;
                counter++;
            }
            if (temp.Length > 1)
            {
                if (!Array.Exists(res, element => element == temp[0]))
                {
                    res[counter] = i;
                    counter++;
                }
            }

        }

        var res2 = new int[counter];

        Array.Copy(res, res2, counter);

        return res2;
    }

    private static double find_circle_area(double radius)
    {
        // write your code here
        return 3.14 * radius * radius;
    }

    private static int calculate_sum(int[] lst)
    {
        // write your code here
        int sum = 0;

        foreach (var i in lst)
        {
            if (i == 7)
            {
                return sum;
            }

            sum += i;
        }

        return sum;
    }

    private static double calculate_circumference(double radius)
    {
        // write your code here
        return Math.PI * (radius * 2);
    }

    private static int[] cumulative_addition(int[] elements_array)
    {
        // write your code here

        int sum = 0;
        var res = new int[2];

        foreach (var i in elements_array)
        {
            sum += i;
        }


        res[0] = sum;
        res[1] = elements_array.Length;
        return res;

    }

    private static double average(int[] values)
    {
        // write your code here
        return values.Sum() / (double)values.Length;

    }

    private static int factorial(int number)
    {
        // write your code here
        int counter = number;
        var res = number;

        while (counter != 1)
        {
            res *= (counter - 1);
            counter--;
        }

        return res;
    }

    private static string odd_even(int number)
    {
        // write your code here
        if (number % 2 == 0)
        {
            return "زوجي";
        }

        return "فردي";
    }

    private static string CountDown(int number)
    {
        // write your code here
        StringBuilder sb = new StringBuilder();

        for (int i = number; i >= 0; i--)
        {
            sb.Append($"{i} ");
        }

        string res = sb.ToString().Trim();


        return res;
    }

    private static string HashtagIt(string[] my_array)
    {
        // write your code here
        string res = "";

        foreach (var str in my_array)
        {
            res += str.Replace($"{str}", $"#{str} ");
        }

        return res.Trim();
    }

    private static string replaceThe(string txt)
    {
        // write your code here
        string res;
        var v = new[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };


        int index = txt.IndexOf("the ", StringComparison.InvariantCultureIgnoreCase);

        int checkIndex = index + 4;

        foreach (char c in v)
        {
            if (txt[checkIndex] == c)
            {
                res = txt.Replace("the", "an", StringComparison.InvariantCultureIgnoreCase);
                return res;
            }
        }

        res = txt.Replace("the", "a", StringComparison.InvariantCultureIgnoreCase);

        return res;
    }

    private static int left_digit(string strParam)
    {
        // write your code here
        char theChar = 'a';


        for (int i = 0; i < strParam.Length; i++)
        {
            char c = strParam[i];
            if (char.IsNumber(c))
            {
                theChar = c;
                break;
            }
        }

        string s = char.ToString(theChar);
        int res = int.Parse(s);

        return res;
    }

    public static string operation(int num1, int num2)
    {
        // write your code here
        if (num1 / num2 == 24)
        {
            return "divided";
        }
        if (num1 + num2 == 24)
        {
            return "added";
        }

        if (num1 - num2 == 24)
        {
            return "subtracted";
        }

        if (num1 * num2 == 24)
        {
            return "multiplied";
        }

        return "None";
    }

    private static string reverse_case(string strParam)
    {
        // write your code here
        string res = "";

        foreach (char letter in strParam)
        {
            if (char.IsLower(letter))
            {
                res += letter.ToString().ToUpper();
            }
            else
            {
                res += letter.ToString().ToLower();
            }
        }

        return res;
    }

    private static int exponent_x(int number, int exponent)
    {
        // write your code here
        int res = number;

        for (int i = 1; i < exponent; i++)
        {
            res *= number;
        }

        return res;
    }

    private static int count_char(string sentence, string ch)
    {
        // write your code here
        int counter = 0;

        foreach (char letter in sentence)
        {
            if (letter.ToString().Equals(ch))
            {
                counter++;
            }
        }

        return counter;
    }

    public static bool match_arrays(string[] array1, string[] array2)
    {
        // write your code here
        bool flag = false;

        if (array1.Length == array2.Length)
        {
            foreach (string i in array1)
            {
                if (array2.Contains(i))
                {
                    flag = true;
                    continue;
                }

                flag = false;
                return flag;
            }
        }

        return flag;
    }

    private static bool allSameCase(string word)
    {
        // write your code here
        int caps = 0;
        int lows = 0;

        foreach (var t in word)
        {
            if (char.IsUpper(t))
            {
                caps++;
                continue;
            }

            lows++;
        }

        if (caps == 0 || lows == 0)
        {
            return true;
        }

        return false;
    }

    public static int returnStringLetters(string string1, string string2)
    {
        // write your code here
        int counter = 0;
        foreach (var i in string1)
        {
            counter++;
        }

        int counter2 = 0;
        foreach (var i in string2)
        {
            counter2++;
        }

        return counter2 > counter ? counter2 : counter;

    }

    private static int[] delete_element_in_array(int[] arr, int index)
    {
        // write your code here
        int[] dest = new int[arr.Length - 1];
        if (index > 0)
            Array.Copy(arr, 0, dest, 0, index);

        if (index < arr.Length - 1)
            Array.Copy(arr, index + 1, dest, index, arr.Length - index - 1);

        return dest;
    }

    public static string input_type(string value)
    {
        // write your code here

        if (int.TryParse(value, out int ii))
        {
            return "integer";
        }
        if (double.TryParse(value, out double dd))
        {
            return "double";
        }

        return "string";
    }

    public static int[] primes_nums(int[] numbers)
    {
        // write your code here
        List<int> output = new List<int>();

        foreach (int i in numbers)
        {
            if (i is 2 or 3 or 5)
            {
                output.Add(i);
            }
            if (!(i % 2 == 0 || i % 3 == 0 || i % 5 == 0))
            {
                output.Add(i);
            }
        }

        return output.ToArray();
    }

    public static int search(string word, string character)
    {
        // write your code here
        foreach (char c in word)
        {
            if (c.ToString() == character)
            {
                return word.IndexOf(c, 0);
            }
        }

        return -1;
    }

    public static string word_repeat(string word, int n)
    {
        // write your code here
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            sb.Append($"{word} ");
        }

        return sb.ToString().Trim();
    }

    public static string less_or_more_than_zero(int number)
    {
        return number switch
        {
            // write your code here
            > 0 => "Greater than zero",
            < 0 => "Less than zero",
            _ => "Equal to zero"
        };
    }

    public static int sum_even(int[] arr)
    {
        // write your code here
        int sum = 0;

        foreach (int n in arr)
        {
            if (n % 2 == 0)
            {
                sum += n;
            }
        }

        return sum;
    }

    public static int[] getPrimesBetween(int a, int b)
    {
        // write your code here
        var list = new List<int>();
        for (int i = a; i <= b; i++)
        {
            if (i is 2 or 3 or 5 or 7)
            {
                list.Add(i);
            }
            if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 || i % 9 == 0 || i == 1)
            {
                continue;
            }

            list.Add(i);
        }

        return list.ToArray();
    }

    private static double convertPercent(string percentage)
    {
        // write your code here


        var sb = new StringBuilder();

        for (int i = 0; i < percentage.Length - 1; i++)
        {
            sb.Append(percentage[i]);
        }

        string res = sb.ToString();

        var output = Convert.ToDouble(res) / 100;

        return output;

    }

    public static int name_char_length(string name)
    {
        // write your code here
        int counter = 0;
        foreach (var i in name)
        {
            counter++;
        }
        return counter;
    }

    public static string isEvenOrOdd(int num)
    {
        // write your code here
        if (num % 2 == 0 && num > 1)
        {
            return "even";
        }

        return "odd";
    }

    private static int isMirroredDecimal_places(string num)
    {
        // write your code here
        if (!num.Contains('.')) return 0;

        int counter = 0;
        int i = num.IndexOf('.');

        for (int j = i; j < num.Length - 1; j++)
        {
            counter++;
        }

        return counter;
    }

    private static bool isMirrored(int num)
    {
        // write your code here
        string input = num.ToString();
        StringBuilder sb = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString() == input;

    }

    public static int sum_two_smallest_nums(int[] arr)
    {
        // write your code here
        int smallest = arr[0];
        int small = arr[1];


        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] < smallest)
            {
                smallest = arr[i];
                continue;
            }

            if (arr[i] >= small) continue;

            small = arr[i];
        }

        return small + smallest;
    }

    public static int number_sum(int num)
    {
        // write your code here
        int sum = 0;

        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }

        return sum;
    }

    public static string reverse_words(string str1, string str2)
    {
        // write your code here
        return $"{str2}, {str1}";

    }

    public static bool stringCheck(string[] value)
    {
        // write your code here
        for (int i = 0; i < value.Length - 1; i++)
        {
            if (!value[i].Equals(value[i + 1]))
            {
                return false;
            }
        }

        return true;
    }

    public static bool kSumSubset(string dateString)
    {
        // write your code here
        string date = string.Empty;

        date = dateString.Substring(0, 4);

        int numDate = int.Parse(date);

        return numDate is <= 2018 and >= 1823;
    }

    public static int last_elm(int[] arr)
    {
        // write your code here
        return arr[^1];

    }

    public static int[] get_duplicate_elements(int[] arr)
    {
        // write your code here

        var sortedArray = new List<int>();

        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                if (sortedArray.Contains(arr[i]))
                {
                    continue;
                }
                sortedArray.Add(arr[i]);
            }
        }

        arr = sortedArray.ToArray();
        return arr;
    }

    public static string is_same(string name1, string name2)
    {
        // write your code here
        return name1.Equals(name2) ? "متشابهتين" : "غير متشابهتين";

    }
    #endregion

    #region MediumProblems

    public static string[] find_prefix(string[] words, string text)
    {
        // write your code here
        var res = new List<string>();

        foreach (var word in words)
        {
            if (word.Substring(0, 2).ToLower().Equals(text.ToLower()))
            {
                res.Add(word);
            }
        }

        if (res.Count == 0)
        {
            res.Add("No matches found");
        }

        return res.ToArray();
    }

    public static bool find_element(int[] elements_array, int element)
    {
        // write your code here
        foreach (var i in elements_array)
        {
            if (elements_array.Contains(element))
            {
                return true;
            }
        }

        return false;
    }

    public static bool timePeriod(string date1, string date2)
    {
        // write your code here
        if (DateTime.Parse(date1) < DateTime.Parse(date2))
        {
            if (DateTime.Parse(date1) < DateTime.Today && DateTime.Parse(date2) < DateTime.Today)
            {
                return true;
            }
        }

        return false;
    }

    public static int smallest_number(int[] arr)
    {
        // write your code here
        int smallest = arr[1];

        foreach (var i in arr)
        {
            if (i < smallest)
            {
                smallest = i;
            }
        }

        return smallest;
    }

    public static bool str_len_comparison(string[] words)
    {
        // write your code here
        int len = words[0].Length;

        foreach (string word in words)
        {
            int len2 = word.Length;
            if (len == len2)
            {
                continue;
            }

            return false;
        }

        return true;
    }

    public static bool[] solution(int[] numbers, int left, int right)
    {
        List<bool> result = new List<bool>();
        List<int> range = new List<int>();

        for (int i = left; i <= right; i++)
        {
            range.Add(i);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            foreach (int j in range)
            {
                if ((i + 1) * j == numbers[i])
                {
                    result.Add(true);
                    break;
                }

                if (j == right)
                {
                    result.Add(false);
                }
            }
        }

        return result.ToArray();
    }

    public static int solution(string pattern, string source)
    {
        int result = 0;
        List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };

        int substringLength = pattern.Length;

        for (int i = 0; i < source.Length; i++)
        {
            foreach (var num in pattern)
            {

            }
        }

        return result;
    }

    public static bool checkPalindrome(string inputString)
    {
        return inputString.ToCharArray().SequenceEqual(inputString.Reverse());
    }

    public static int adjacentElementsProduct(int[] inputArray)
    {
        int res = inputArray[0] * inputArray[1];

        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int prod = inputArray[i] * inputArray[i + 1];

            if (prod > res)
            {
                res = prod;
            }
        }

        return res;
    }

    public static int countWords(string txt)
    {
        int numberOfWords = 1;

        foreach (char c in txt)
        {
            if (c == ' ')
            {
                numberOfWords++;
            }
        }

        return numberOfWords;
    }

    public static string deleteLastChar(string word)
    {
        if (word.Length == 1)
        {
            return "";
        }

        return word.Substring(0, word.Length - 1);
    }

    private static string date_format(string date)
    {
        var year = "";
        var month = "";
        var day = "";
        var counter = 0;

        foreach (var character in date)
        {
            if (character == '/')
            {
                counter++;
                continue;
            }

            if (counter == 0)
            {
                year += character;
                continue;
            }

            if (counter == 1)
            {
                day += character;
                continue;
            }

            month += character;
        }

        return $"{date} | {date.Replace('/', '-')} | {day}/{month}/{year}";
    }

    public static bool stringContains(string firstName, string contains)
    {
        // write your code here
        return firstName.Contains(contains);
    }
    #endregion

    #region HardProblems
    public static string oddsVsEvens(int num)
    {
        // write your code here
        List<char> charArray = num.ToString().ToList();

        List<int> numberArray = new();

        foreach (var c in charArray)
        {
            string s = c.ToString();
            numberArray.Add(int.Parse(s));
        }

        int odds = 0;
        int evens = 0;

        foreach (var number in numberArray.Where(number => number != 0))
        {
            if (number % 2 == 0)
            {
                evens += number;
            }
            else
            {
                odds += number;
            }
        }

        if (evens > odds)
        {
            return "even";
        }

        if (evens < odds)
        {
            return "odd";
        }

        return "equal";
    }

    public static bool math_expr(string expr)
    {
        // write your code here
        List<char> chars = new List<char> { '+', '-', '*', '/' };

        foreach (char c in expr)
        {
            if (int.TryParse(c.ToString(), out _) || chars.Exists(i => i == c))
            {
                continue;
            }

            return false;
        }

        return true;
    }

    public static bool useRegex(String input)
    {
        Regex regexPlus = new("[0-9]+\\+[0-9]", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        Regex regexMin = new("[0-9]+-[0-9]", RegexOptions.IgnoreCase);
        Regex regexProd = new("[0-9]+\\*[0-9]", RegexOptions.IgnoreCase);
        Regex regexDiv = new("[0-9]+/[0-9]", RegexOptions.IgnoreCase);

        if (regexPlus.IsMatch(input) || regexMin.IsMatch(input) || regexProd.IsMatch(input) || regexDiv.IsMatch(input))
        {
            return true;
        }

        return false;
    }

    public static string addStrNums(string num1, string num2)
    {
        // write your code here

        if (int.TryParse(num1, out _) && int.TryParse(num2, out _))
        {
            return (int.Parse(num1) + int.Parse(num2)).ToString();
        }

        return "-1";
    }

    public static int bin_to_oct(string b)
    {
        // write your code here
        long Temp, BinaryNumber, p = 1, i = 1, j, d;
        long DecimalNo = 0;
        long OctalNo = 0;

        Temp = Int64.Parse(b);

        for (j = Temp; j > 0; j = j / 10)
        {
            d = j % 10;
            if (i == 1)
                p = p * 1;
            else
                p = p * 2;
            DecimalNo = DecimalNo + (d * p);
            i++;
        }
        i = 1;
        for (j = DecimalNo; j > 0; j = j / 8)
        {
            OctalNo = OctalNo + (j % 8) * i;
            i = i * 10;
            BinaryNumber = Temp / 8;
        }

        return (int)OctalNo;
    }

    public static string cap_space(string txt)
    {
        // write your code here
        List<string> res = new();

        foreach (var t in txt)
        {
            if ((int)t is > 96 and < 123)
            {
                res.Add(t.ToString());
                continue;
            }

            if ((int)t is > 64 and < 91)
            {
                res.Add(" ");
                res.Add(t.ToString().ToLower());

            }
        }


        return string.Join("", res);
    }

    public static string oct_to_bin(int octal)
    {
        // write your code here
        string octalS = octal.ToString();
        int i = 0;
        string binary = "";
        while (i < octalS.Length)
        {
            char c = octalS[i];
            switch (c)
            {
                case '0':
                    binary += "000";
                    break;
                case '1':
                    binary += "1";
                    break;
                case '2':
                    binary += "010";
                    break;
                case '3':
                    binary += "011";
                    break;
                case '4':
                    binary += "100";
                    break;
                case '5':
                    binary += "101";
                    break;
                case '6':
                    binary += "110";
                    break;
                case '7':
                    binary += "111";
                    break;
            }
            i++;
        }

        return binary;
    }



    #endregion

    #region National Day
    public static int getCentury(int year)
    {
        // write your code here
        return (year + 99) / 100;
    }

    public static int findElement92(int[] numbers)
    {
        // write your code here
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 92)
            {
                return i;
            }
        }

        return 92;
    }

    public static int[] getFirstLastEl(int[] numbers)
    {
        // write your code here
        List<int> resList = new List<int>();

        resList.Add(numbers[0]);

        if (numbers.Length > 1)
        {
            resList.Add(numbers[^1]);
        }

        return resList.ToArray();
    }

    public static int[] extractNumber(int num, int[] nums)
    {
        // write your code here
        if (!Array.Exists(nums, i => i == num))
        {
            return nums;
        }

        List<int> resList = new List<int>();

        int counter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == num)
            {
                counter++;
                continue;
            }

            resList.Add(nums[i]);
        }

        for (int j = 0; j < counter; j++)
        {
            resList.Add(num);
        }

        return resList.ToArray();
    }

    public static string yearsSinceNationalDay(int year)
    {
        // write your code here
        return year < 1930 ? "Not Valid Year Entry" : (year - 1930).ToString();
    }

    public static string[] get_available_IPs(string ip1, string ip2, string[] addresses)
    {
        // write your code here

        List<string> result = new List<string>();

        long ip1Number = IPAddressToDecimal(ip1);
        long ip2Number = IPAddressToDecimal(ip2);

        long min = IPAddressToDecimal(addresses[0]);
        long max = 0;
        int counter = 0;

        foreach (var avAddress in addresses)
        {
            long add = IPAddressToDecimal(avAddress);

            if (add >= ip1Number && add <= ip2Number)
            {
                if (add <= min)
                {
                    min = add;
                    result.Add(avAddress);
                }
                else
                {
                    result.Insert(counter, avAddress);
                    if (add > max)
                    {
                        max = add;
                    }
                    counter++;
                }
            }
        }

        return result.ToArray();
    }

    public static long IPAddressToDecimal(string ipAddress)
    {
        // IP to Dec formula = 16777216*w + 65536*x + 256*y + z 
        // where IP Address = w.x.y.z

        // Get the indices of dots
        int firstDotIndex = ipAddress.IndexOf('.');
        int secondDotIndex = ipAddress.IndexOf('.', firstDotIndex + 1);
        int thirdDotIndex = ipAddress.IndexOf('.', secondDotIndex + 1);

        // Separate IP sections and convert to int
        int sec1 = int.Parse(ipAddress.Substring(0, firstDotIndex));
        int sec2 = int.Parse(ipAddress.Substring(firstDotIndex + 1, secondDotIndex - firstDotIndex - 1));
        int sec3 = int.Parse(ipAddress.Substring(secondDotIndex + 1, thirdDotIndex - secondDotIndex - 1));
        int sec4 = int.Parse(ipAddress.Substring(thirdDotIndex + 1));

        // Calculate decimal from IP
        var res = 16777216 * (long)sec1 + 65536 * (long)sec2 + 256 * (long)sec3 + (long)sec4;

        return res;
    }

    public static string getKingName(int nationalDay)
    {
        // write your code here
        if (nationalDay is >= 1 and <= 21)
        {
            return "عبدالعزيز";
        }
        if (nationalDay is >= 22 and <= 32)
        {
            return "سعود";
        }
        if (nationalDay is >= 32 and <= 42)
        {
            return "فيصل";
        }
        if (nationalDay is >= 43 and <= 50)
        {
            return "خالد";
        }
        if (nationalDay is >= 51 and <= 74)
        {
            return "فهد";
        }
        if (nationalDay is >= 75 and <= 84)
        {
            return "عبدالله";
        }
        if (nationalDay is >= 85 and <= 92)
        {
            return "سلمان";
        }

        return "Not valid entry.";
    }

    public static int remaining_download_time(int file_size, int[] bytes_downloaded, int minutes_of_observation)
    {
        // write your code here
        if (!bytes_downloaded.Any()) return file_size;

        int total = bytes_downloaded.Sum();

        IEnumerable<int> trr = bytes_downloaded.Reverse();

        int d = trr.Take(minutes_of_observation).Sum();

        var avg = d / minutes_of_observation;

        return (file_size - total) / avg;
    }

    public static string[] get_king_names(int year1, int year2)
    {
        // write your code here
        var azoz = fillListWithRange(1932, 1953);
        var saud = fillListWithRange(1953, 1964);
        var faisal = fillListWithRange(1964, 1975);
        var khalid = fillListWithRange(1975, 1982);
        var fahad = fillListWithRange(1982, 2005);
        var abdullah = fillListWithRange(2005, 2015);
        var salman = fillListWithRange(2015, 2022);

        List<string> names = new List<string>();

        for (int i = year1; i <= year2; i++)
        {
            if (azoz.Exists(y => y == i))
            {
                names.Add("عبدالعزيز");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (saud.Exists(y => y == i))
            {
                names.Add("سعود");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (faisal.Exists(y => y == i))
            {
                names.Add("فيصل");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (khalid.Exists(y => y == i))
            {
                names.Add("خالد");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (fahad.Exists(y => y == i))
            {
                names.Add("فهد");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (abdullah.Exists(y => y == i))
            {
                names.Add("عبدالله");
                break;
            }
        }
        for (int i = year1; i <= year2; i++)
        {
            if (salman.Exists(y => y == i))
            {
                names.Add("سلمان");
                break;
            }
        }


        return names.ToArray();
    }

    public static List<int> fillListWithRange(int from, int to)
    {
        List<int> res = new List<int>();

        for (int i = from; i <= to; i++)
        {
            res.Add(i);
        }


        return res;
    }

    #endregion


}
