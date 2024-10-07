using CSharpStringExercises.Classes;
using System;
using System.Text;

namespace CSharpStringExercises
{
	internal class Program
	{
		static void Main()
		{
			// Add your calling code here
			// This is essential to demonstrate you have tested Q3 and Q4
			// You will be writing your own tests for the others.
			// However it may be useful to test them here as you develop them 
			
			Console.WriteLine(StringExercises.PigLatin("&,%%!") + "\n");

            Console.WriteLine(StringExercises.PigLatin("I don't like Mondays much.") + "\n");

            Console.WriteLine(string.Join(",", StringExercises.Wave("hello world")) + "\n");

			Console.WriteLine(StringExercises.Anagram("star", new string[] { "rats", "arts", "arc" }));

			StringExercises.WriteHelloCharacterCodes();
			StringExercises.WriteHelloAsBytes();

			byte[] code = new byte[] { 206, 188, 206, 174, 206, 187, 206, 191 };
			Console.WriteLine(StringExercises.ReadCharacterCodes(code) + "\n");

			int[] intCodes = new int[] { 956, 942, 955, 959 };
			Console.WriteLine(StringExercises.ReadCharacterCodes(intCodes) + "\n");

			string variableName = StringExercises.WriteVariableName("Some silly variable name", StringExercises.VariableNameType.CamelCase);
            string variableName2 = StringExercises.WriteVariableName("Some silly variable name", StringExercises.VariableNameType.SnakeCase);
            Console.WriteLine(variableName);
            Console.WriteLine(variableName2);
        }

	}
}