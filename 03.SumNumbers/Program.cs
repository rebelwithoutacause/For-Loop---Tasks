int numberCount = int.Parse(Console.ReadLine());

double sum = 0;

for (int i = 0; i < numberCount; i+=1) 
{
    sum += double.Parse(Console.ReadLine());
}
Console.WriteLine(sum);
