Console.WriteLine("Type your number:  ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >=99 && num <=1000)
{
    int x = (num % 100 - num % 10) / 10;
    Console.WriteLine(x);
}
else 
{
    Console.WriteLine("This is not a three-digit number.");

}
