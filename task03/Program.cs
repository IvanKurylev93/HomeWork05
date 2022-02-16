// Найти сумму чисел одномерного массива стоящих на нечетной позиции;
int[] mass = new int[10]; 
 
for (int i = 0; i < mass.Length; i++) 
{ 
    mass[i] = new Random().Next(99, 899); 
    Console.Write(mass[i] + " "); 
} 
Console.WriteLine(); 
int summ = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (i%2==1)
    {
        summ=summ+mass[i];
    }
}
Console.WriteLine(summ);