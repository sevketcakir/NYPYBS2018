﻿using System;

namespace Dongu3IO
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write("Dizinin boyutunu giriniz=");
			int boyut = Convert.ToInt32(Console.ReadLine());
			bool [] dizi = new bool [boyut];
			dizi [5] = true;
			for (int i = 0; i < boyut; i++)
				Console.WriteLine(dizi[i]);
			Console.ReadLine();
		}
	}
}
