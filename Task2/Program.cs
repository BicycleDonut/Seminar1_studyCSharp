Console.Write("Ведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA*numberB==numberA)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да"); 
}