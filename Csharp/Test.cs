using System;
using system.string;
public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    string[] StringNumberList = numbers.split(' ');
    int[] NumberList = new int[StringNumberList.length];
    for(int i=0;i<StringNumberList.length;i++)
    {
        NumberList[i] = int.parse(StringNumberList[i]);
    }
    return "throw towel";
  }
}