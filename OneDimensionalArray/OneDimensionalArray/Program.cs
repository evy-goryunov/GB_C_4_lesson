using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewArrayLib;


/* Горюнов Евгений
 * а) Дописать класс для работы с одномерным массивом. 
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива 
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),  
 * метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов. 
б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 */

namespace OneDimensionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			NewArray nA = new NewArray(5);

			for (int i = 0; i < nA.arr.Length; i++)
			{
				Console.WriteLine(nA.arr[i]);
			}

			Console.WriteLine(nA.Sum());

			int[] r = nA.InverseToNewArray();
			for (int i = 0; i < nA.arr.Length; i++)
			{
				Console.WriteLine(r[i]);
			}

			int[] f = nA.Multi(2);
			for (int i = 0; i < nA.arr.Length; i++)
			{
				Console.WriteLine(f[i]);
			}

			int max = nA.MaxCount();
			Console.WriteLine($"кол-во максимальных элементов в массиве {max}");
		}
	}
}
