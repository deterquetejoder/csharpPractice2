using System;

Console.WriteLine("Type your number:  ");
int num = Convert.ToInt32(Console.ReadLine());

List<int> digits = new List<int>();

foreach (char c in num.ToString())
{
    int digit = int.Parse(c.ToString());
    digits.Add(digit);
}

int lg = digits.Count();
if (lg >= 3)
{
int ThDigit = digits[2];
Console.WriteLine(ThDigit);
}
else
{
  Console.WriteLine("There is no third digit found "); // If the input is less than or equal to one, there are
}