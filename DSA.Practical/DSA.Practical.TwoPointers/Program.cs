// See https://aka.ms/new-console-template for more information

//Two pointers

using Newtonsoft.Json;
using System.Text.Json.Nodes;

var inputArray = new int[] { 1, 3, 4, 6, 8, 10, 13 };
var targetNum = 13;

var mainClass = new TwoPointersFunction();

var result = mainClass.TwoPointers2Sum(inputArray, targetNum);

Console.WriteLine(result);

var result2 = mainClass.TwoPointers3SumEqualZero(new int[] { -1, 0, 1, 2, -1, -1 });
Console.WriteLine(JsonConvert.SerializeObject(result2));


Console.WriteLine("Hello, World!");

public class TwoPointersFunction
{
    public string TwoPointers2Sum(int[] arrays, int targerNum)
    {
        var inputArray = new int[] { 1, 3, 4, 6, 8, 10, 13 };
        var targetNum = 13;

        int left = 0;
        int right = inputArray.Length - 1; //7 - 1 = 6
        while (left < right)
        {
            int currentSum = inputArray[left] + inputArray[right];

            if (currentSum == targetNum)
            {
                return $"{left} {right}";
            }

            if (currentSum > targetNum)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return "Empty!";
    }

    /// <summary>
    /// Given list of sorted interger, return sum of 3 numbers equal to zero
    /// </summary>
    /// <param name="arrays"></param>
    /// <returns></returns>
    public IList<List<int>> TwoPointers3SumEqualZero(int[] arrays)
    {
        Array.Sort(arrays);
        var result = new List<List<int>>();
        var left = 0;
        var right = arrays.Length - 1;
        for (int i = 0; i < arrays.Length - 2; i++)
        {
            if (i > 0 && arrays[i] == arrays[i - 1]) // Skip duplicates
                continue;
            left = i + 1;
            while (left < right)
            {
                var tempSum = arrays[i] + arrays[left] + arrays[right];
                if (tempSum == 0)
                {
                    result.Add(new List<int>() { arrays[i], arrays[left], arrays[right] });
                    //avoid duplicate
                    while (left < right && arrays[left] == arrays[left + 1])
                    { 
                        left++;
                    }

                    while (left < right && arrays[right] == arrays[right - 1])
                    {
                        right--;
                    }

                    left++;
                    right--;
                }
                else if (tempSum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
        }
        
        return result;
    }

    public void Swap(int[] arrays, int i, int j)
    {
        int temp = arrays[i];
        arrays[i] = arrays[j];
        arrays[j] = temp;
    }

    public int[] MoveZeroToRightArray(int[] arrays)
    {
        int length = arrays.Length - 1;
        int i = 0;
        int j = 0;
        while (j < length)
        { 
             

        }


        return new int[0];
    }
}