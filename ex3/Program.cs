// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран


int[]arr=new int[8];
Random rnd = new Random();
for (int i=0; i<arr.Length; i++)
{
    arr[i]=rnd.Next(0,189);
    Console.Write($"{arr[i]}  ");
}



