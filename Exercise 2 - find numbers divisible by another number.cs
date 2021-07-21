using System;
using System.Linq;

//Write a program in C# Sharp to find numbers divisible by another number
public class Program
{

	public static void Main(){
	
		int[] list = new int[]{315, 978, 834, 688, 75, 823, 413, 110, 410, 848};

		int divisible = 2;
		Func<int,int,bool> it_divides = (num, num_2) => num % num_2 == 0;
		
		foreach (int num in list){
			if (it_divides(num, divisible)) Console.WriteLine(num + " is divisible by " + divisible);
			else Console.WriteLine(num + " is not divisible by " + divisible);
		}
	}
}
