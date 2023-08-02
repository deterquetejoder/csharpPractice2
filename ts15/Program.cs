using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] weekDays = new string[] { 
     "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Satturday", "Sunday"
     };

Console.WriteLine("Enter the number ");
int inp = Convert.ToInt32(Console.ReadLine());

if(inp > 5 && inp < 8)
{
Console.WriteLine($"yes, {weekDays[inp-1]} is a weekend!");
}
else if (inp>0 && inp< 6)
{
    Console.WriteLine($"No, {weekDays[inp-1]} is a working day..");
}
else
{
    Console.WriteLine("There is no this day on a week");
}