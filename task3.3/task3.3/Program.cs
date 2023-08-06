using task3._3;

PrimeNumber prime=new PrimeNumber();
Console.WriteLine("enter the number you want to check");
int check=int.Parse(Console.ReadLine());
if (prime.check(check))
{
    Console.WriteLine(check+"  is prime number");
}
else
{
    Console.WriteLine(check + "  is not prime number");
}

