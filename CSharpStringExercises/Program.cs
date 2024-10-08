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
			// This is essential to demonstrate you have tested Q2 and Q3
			// Tests have already be written for Q1, Q4 and Q8
			// You will need to write your own tests for Q5, Q6, Q7 and the extension.
			// However it may be useful to test all your subprograms from here as you develop them 
			
			
			Console.OutputEncoding = Encoding.Unicode; // Allows greek letters to be output but not chinese characters

			Console.WriteLine("Q1:");
			Console.WriteLine(string.Join(",", StringExercises.Wave("hello world")) + "\n");

			Console.WriteLine("Q2:");
			StringExercises.WriteHelloCharacterCodes();
			Console.WriteLine();

			Console.WriteLine("Q3:");
			StringExercises.WriteHelloAsBytes();

			Console.WriteLine("Q4:");
			int[] intCodes =[ 956, 942, 955, 959 ];
			string intCodesToString = StringExercises.ReadCharacterCodes(intCodes);
 			Console.WriteLine($"[ 956, 942, 955, 959 ] => {intCodesToString}\n");

			Console.WriteLine("Q5:");
			byte[] codes = [ 206, 188, 206, 174, 206, 187, 206, 191 ];
			string byteCodesToString = StringExercises.ReadCharacterCodes(codes);
			Console.WriteLine($"[ 206, 188, 206, 174, 206, 187, 206, 191 ] => {byteCodesToString}\n");

			Console.WriteLine("Q6:");
			int numAnagrams = StringExercises.Anagram("star", ["rats", "arts", "arc"]);
			Console.WriteLine($"[rats, arts, arc] contains {numAnagrams} anagrams of star\n");

			Console.WriteLine("Q7");
			string input = "Happy Monday";
			string snakeCase = StringExercises.WriteVariableName(input, StringExercises.VariableNameType.SnakeCase);
			string camelCase = StringExercises.WriteVariableName(input);
			string pascalCase = StringExercises.WriteVariableName(input, StringExercises.VariableNameType.PascalCase);
			Console.WriteLine($"{input} => {snakeCase} {camelCase} {pascalCase}\n");

			Console.WriteLine("Q8:");
			Console.WriteLine($"&,%%! => {StringExercises.PigLatin("&,%%!")}");
            Console.WriteLine($"I don't like Mondays much.\" => {StringExercises.PigLatin("I don't like Mondays much.")}\n");

			Console.WriteLine("Q9:");
			int keyPresses = StringExercises.CalculateKeyPresses(["War", "and", "Peace"]);
			Console.WriteLine($"War and Peace requires {keyPresses} key presses");
        }

	}
}