using System;

Console.WriteLine("Type your number:  ");
int num = Convert.ToInt32(Console.ReadLine());
int number = 0;

if (num < 0)
{
   number =  num * (-1);
}
else
{
   number =  num;
}

List<int> digits = new List<int>();

foreach (char c in number.ToString())
{
    int digit = int.Parse(c.ToString());
    digits.Add(digit);
}


if (digits.Count() >= 3)
{
int ThDigit = digits[2];
Console.WriteLine(ThDigit);
}
else
{
  Console.WriteLine("There is no third digit found "); 
}