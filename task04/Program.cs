//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
int[] mass = new int[10]; 
 
for (int i = 0; i < mass.Length; i++) 
{ 
    mass[i] = new Random().Next(1, 99); 
    Console.Write(mass[i] + " "); 
} 
Console.WriteLine(); 

int max = mass[0];
int min = mass[0];
for (int i = 1; i < 10; i++)
{
    if (mass[i] < min) min = mass[i];
    if (mass[i] > max) max = mass[i];
}
            
Console.WriteLine("Разница между максимальным и минимальным = {0}", max - min);