// See https://aka.ms/new-console-template for more information
using System;

class FirstProgram
{  
    //new method
    public static void NewMethod()
    {
        Console.WriteLine("Hello World");
    }
    public static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    public static void Main(string []args)
    {
        //new line
        NewMethod();
        int n;
        Console.WriteLine("Nhap so luong phan tu");

        n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i <n; i++)
        {
            Console.WriteLine("Nhap phan tu thu "+(i+1));
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Tong phan tu trong mang = " + Sum(arr));

    }
}

