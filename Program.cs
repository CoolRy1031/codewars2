using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.XPath;

// Console.WriteLine(basicOp('-', 15, 18));
static double basicOp(char operation, double value1, double value2)
{
   switch(operation)
   {
    case '+' : return value1 + value2;
    case '-' : return value1 - value2;
    case '*' : return value1 * value2;
    case '/' : return value1 / value2;
    default:
    throw new System.ArgumentException("wrong operation");
   }
}


// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

// If the input is an empty array or is null, return an empty array.

static int [] CountPositivesSumNegatives(int[] input)
{
  if (input == null || input.Length == 0)
  {
    return new int [] {};
  }
  var positiveCount = 0;
  var negativeCount = 0;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] > 0)
    {
      positiveCount++;
    }
    else
    {
      negativeCount += input[i];
    }
  }
  return new int[] {positiveCount,negativeCount};  
}

// Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.

public class Kata
{
  public int Min(int[] list)
  {
    return list.Min();
  }
  
  public int Max(int[] list)
  {
    return list.Max();
  }

}

// public class Kata2
// {
//     public static string RemoveExclamationMarks(string s)
//   {
//     StringBuilder sb = new();
//     foreach(var item in s)
//     {
//       if (item != '!')
//       {
//         sb.Append(item);
//       }
//       return sb.ToString();
//     }
//   }
// }

// A hero is on his way to the castle to complete his mission. However, he's been told that the castle is surrounded with a couple of powerful dragons! each dragon takes 2 bullets to be defeated, our hero has no idea how many bullets he should carry.. Assuming he's gonna grab a specific given number of bullets and move forward to fight another specific given number of dragons, will he survive?

// Return true if yes, false otherwise 

class Kata3
{
    public static bool Hero(int bullets, int dragons)
    {
        return bullets >= (dragons*2);
    }
}

// Complete the square sum function so that it squares each number passed into it and then sums the results together.
public class Kata4
{
  static int SquareSum(int[] numbers)
  {
    var sum = 0;
    foreach(var num in numbers)
    {
      var square = num * num;
      sum += square;
    }
    return sum;
  }
}

// 
public class kata5
{
  static string areYouPlayingBanjo(string name)
  {
    if (name.StartsWith("R") || name.StartsWith("r"))
    {
      return name + " plays banjo";
    }
    return name + " does not play banjo";
  }
}

  public class Converter
{
  public string dnaToRna(string dna)
  {
    if(dna.Contains("T"))
    {
      dna = dna.Replace("T", "U");
    }
    return dna;
  }  
  
}

public class kata6
{
  public string Greet(string name)
  {
    return $"Hello, {name} How are you doing today?";
  }
}

public class Kata7
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    var sum = 0;
    var avg = 0;
    for (var i = 0; i < ClassPoints.Length; i++)
    {
      sum += ClassPoints[i];
    }
    avg = (sum + YourPoints) / (ClassPoints.Length + 1);
    if (YourPoints > avg)
    {
      return true;
    }
    return false;
  }
}

// Given a string, you have to return a string in which each character (case-sensitive) is repeated once.
public class Kata8
{
  public static string DoubleChar(string s)
  {
    var newString = "";
    for (var i = 0; i < s.Length; i++)
    {
      newString += "" + s[i] + s[i];
    }
    return newString;
  }
}

public class kata9
{
  public static int FindSmallestInt(int[] args) 
  {
    int current = args[0];
    foreach (var value in args)
    {
      if (current > value)
      {
        current = value;
      }
    }
      return current;
  }
}

public static class StringExt
{
    public static string ToAlternatingCase (this string s)
    {
      StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsLower(sb[i]))
                    sb[i] = char.ToUpper(sb[i]);
                else
                    sb[i] = char.ToLower(sb[i]);
            }
            return sb.ToString();
    }
}

public static class Program1
{
  public static int[] ReverseSeq(int n)
  {
   int[] reversed = new int[n];
    for(int i=0;i<n;i++){
      reversed[i]=n-i;
    }
    return reversed;
  }
}

public class Kata10
{
static int FizzBuzz(int n)
{
  for (int i = 0; i <= n; i++)
  {
    if (n % 5 == 0 && n % 3 == 0)
    {
      Console.WriteLine("FizzBuzz");
    }
    else if( n % 5 == 0)
    {
      Console.WriteLine("Fizz");
    }
    else if ( n % 3 == 0)
    {
      Console.WriteLine("Buzz");
    }
    else 
    {
      return n;
    }
  }
  return n;
}
}

public class kata11
{
  public static int maxPosPrefixes(List<int> arr)
    {
        int[] positive = arr.Where(x => x > 0).OrderByDescending(x => x).ToArray();
        int[] negative = arr.Where(x => x < 0).OrderBy(x => x).ToArray();
        int[] rearranged = positive.Concat(negative).ToArray();
        int[] psum = new int[arr.Length];
        psum[0] = rearranged[0];
        
        for ( int i = 1; i < arr.length; i++)
        {
            psum[i] = psum[i - 1] + rearranged[i];
        }
        int maxPositiveCount = 0;
        int currentPositiveCount = 0;
        foreach (int num in psum)
        {
            if (num > 0)
            {
                currentPositiveCount++;
                maxPositiveCount = Math.Max(maxPositiveCount, currentPositiveCount);
            }
            else
            {
                currentPositiveCount = 0;
            }
        }

        return maxPositiveCount;
    }

}

public class kata12
{
  public static int getSubstringCount(string s)
    {
        var curr = 1;
        var prev = 0;
        var ans = 0;
        
        for ( int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i-1])
            {
                curr++;
            }
            else ans += Math.Min(curr, prev);
            {
                prev = curr;
                curr = 1;
            }
            
        }
        return ans + Math.Min(curr, prev);
    }
  static int[] ReverseSeq(int n)
  {
    var list = new List<int>();
    for(int i = n; i > 0; i--)
    {
      list.Add(i);
    }
    return list.ToArray();
  }
  static string HoopCount(int n)
  {
    if (n < 10)
    return "Keep at it until you get it";
    if (n >= 10)
    return "Great, now move on to tricks";
    else
    return "That is not a valid input";
  }

  static int RentalCarCost(int d) 
    {
        int carCost = 40;
        int dayCar = carCost * d;
        if ( d >= 7)
        {
          return dayCar - 50;
        }
        if (d>=3 && d < 7)
        {
          return dayCar - 20;
        }
        return dayCar;
    }
    static int StrCount(string str, char letter)
    {
      int count = 0;
      for (int i = 0; i < str.Length; ++i)
      {
        if (str[i] == letter)
        {
          ++count;
        }
      }
      return count;
    }
    static int AreaOrPerimeter(int l, int w)
{
  var area = l * w;
  var perimeter = (l+w)*2;
  if (l == w)
  {
    return area;
  }
  else return perimeter;
}

static int SquareDigits(int n)
{
  var digits = n.ToString();
  var result = "";
  foreach(var c in digits)
  {
    var parse = int.Parse(c.ToString());
    var square = parse * parse;
    result += square.ToString();
  }
  return int.Parse(result);
}

static long RowSumOddNumbers(long n)
{
  long currentValue = GetFirstValueForRow(rowNumber);
  long sum = currentValue;

  for( int i = 1; i < rowNumber; ++i)
  {
    currentValue += 2;
    sum += currentValue;
  }
  return sum;
}

long GetFirstValueForRow(long rowNumber)
{
   return rowNumber * rowNumber - (rowNumber-1);
}
}

