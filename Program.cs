using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace CoderHub;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(isMirrored(191));
        Console.WriteLine(isMirrored(654));
        Console.WriteLine(isMirrored(164461));
        Console.WriteLine(isMirrored(11));
        Console.WriteLine(isMirrored(1));


        Console.ReadLine();
    }

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

    private static string deleteLastChar(string word)
    {
        // write your code here
        if (word.Length == 1)
        {
            return string.Empty;
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < word.Length-1; i++)
        {
            sb.Append(word[i]);
        }

        return sb.ToString();
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

        for (int j = i; j < num.Length-1; j++)
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

        for (int i = input.Length-1; i >= 0; i--)
        {
            sb.Append(input[i]);
        }

        return sb.ToString() == input;

    }

}
