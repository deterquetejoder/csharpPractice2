using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] weekDays = new string[] { 
     "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"
     };

Console.WriteLine("Enter the number ");
int inp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(weekDays[inp-1]);