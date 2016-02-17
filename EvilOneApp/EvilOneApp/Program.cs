using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EvilOneApp
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter sw = new StreamWriter(@"D:\My Stuff\secret plan.txt");
			sw.Write("How I will defeat Captain America.");
			sw.WriteLine("Another genius secret plan by Myself.");
			sw.Write("I'll create an army of clones and ");
			sw.WriteLine("unleash them upon the citizens of Objectville.");

			string location = "the mall";

			for (int number	= 0; number < 6; number++)
			{
				sw.WriteLine("Clone #{0} attacks {1}", number, location);
				if (location == "the mall")
				{
					location = " downtown";
				}
				else
				{
					location = "the mall";
				}
			}
			sw.Close();

			StreamReader spyReader = new StreamReader(@"D:\My Stuff\secret plan.txt");
			StreamWriter spyWriter = new StreamWriter(@"D:\My Stuff\mail to Captain.txt");

			spyWriter.WriteLine("Hi, I have some info for u");

			while (!spyReader.EndOfStream)
			{
				string info = spyReader.ReadLine();
				spyWriter.WriteLine("The evil plan is -> " + info);
			}
			spyReader.Close();
			spyWriter.Close();

			
		}
	}
}
