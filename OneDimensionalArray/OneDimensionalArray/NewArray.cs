using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensionalArray
{
	class NewArray
	{
		public int[] arr;
		Random rand = new Random();
		Dictionary<int, int> dList = new Dictionary<int, int>();


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
				//arr[i] = 5;
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

		/// <summary>
		/// Подсчёт кол-ва вхождений элементов в массив
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, int> CountOfValue()
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (dList.TryGetValue(arr[i], out int a))
				{
					dList[arr[i]] = ++a;
				}
				else
				{
					dList.Add(arr[i], 1);
				}
			}
			
			
			
			//for (int i = 0; i < arr.Length; i++)
			//{
			//	if (!dList.ContainsKey(arr[i]))
			//	{
			//		dList.Add(arr[i], 1);
			//	}
			//	else if(dList.ContainsKey(arr[i]))
			//	{
			//		foreach (int value in dList.Values.ToList())
			//		{
			//			dList[value] = value + 1;
			//		}
			//	}
			//}

			
			

			return dList;
		}
	}
}
