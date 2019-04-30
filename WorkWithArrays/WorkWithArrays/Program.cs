using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Горюнов Евгений
 * Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно. 
 * Заполнить случайными числами.  
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
 * В данной задаче под парой подразумевается два подряд идущих элемента массива. 
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
 */

namespace WorkWithArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[20];
			Random rand = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rand.Next(-10000, 10000);
			}

			// написать код

			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine($"{array[i]} ");
			}
			Console.ReadKey();

		}
	}
}
