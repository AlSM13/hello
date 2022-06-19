using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			String[] strings = {"Qwerty", "man", "Dodo", "Petya", "A", "Windows", "Ara", "Lol", "No", "M"};
			String[] result = new String[strings.Length];

			int index = 0;
			foreach (String s in strings)
            {
				if (s.Length <= 3)
                {
					result[index++] = s;
				}
            }

			Console.WriteLine("Result:");
			for (int i = 0; i < index; i++)
            {
				Console.Write(result[i] + " ");
			}	
		}
	}
}