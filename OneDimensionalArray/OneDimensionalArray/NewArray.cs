using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
	/// <summary>
	/// Класс для работы с одномерными массивами
	/// </summary>
	class NewArray
	{
		public int[] arr;
		Random rand = new Random();


		/// <summary>
		/// заполнение массива случайными числами от 1 до 10 000
		/// </summary>
		/// <param name="a"></param>
		public NewArray(int a)
		{
			arr = new int[a];
			for (int i = 0; i < a; i++)
			{
				arr[i] = rand.Next(1, 10000);
			}
		}

		/// <summary>
		/// первый аргумент - размер массива.
		/// второй аргумент - первое число массива.
		/// третий аргумент - шаг в массиве.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="c"></param>
		public NewArray(int a, int b, int c)
		{
			arr = new int[a];
			arr[0] = b;
			for (int i = 1; i < a; i++)
			{
				arr[i] = arr[i - 1] + c;

			}
		}

		/// <summary>
		/// Метод Sum, который возвращает сумму элементов массива
		/// </summary>
		/// <param name="nA"></param>
		/// <returns></returns>
		public int Sum()
		{
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum = sum + arr[i];
			}

			return sum;
		}

		/// <summary>
		/// Инверсия знака у каждого элемента в массиве
		/// </summary>
		/// <returns></returns>
		public int[] InverseToNewArray()
		{
			int[] newArr = (int[])arr.Clone();
			
			for (int i = 0; i < newArr.Length; i++)
			{
				newArr[i] = newArr[i] * -1;
			}

			return newArr;
		}

		/// <summary>
		/// умножение каждого элемента в массиве на число
		/// </summary>
		/// <param name="multiplicator"></param>
		/// <returns></returns>
		public int[] Multi(int multiplicator)
		{
			
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = arr[i] * multiplicator;
			}

			return arr;


		}

		/// <summary>
		/// Возвращает кол-во максимальных элементов
		/// </summary>
		/// <returns></returns>
		public int MaxCount()
		{
			int maxCount = 0;
			int temp = arr[0];
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > temp)
				{
					temp = arr[i];
				}
			}

			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == temp)
				{
					maxCount++;
				}
			}

			return maxCount;
		}

		
	}
}
