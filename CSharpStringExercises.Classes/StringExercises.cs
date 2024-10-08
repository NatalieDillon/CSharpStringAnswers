using System.ComponentModel;
using System.Text;

namespace CSharpStringExercises.Classes
{
	public class StringExercises
	{
		// 1. Mexican wave
		// The input string will always be lower case but maybe empty.
		// If the character in the string is whitespace then pass over it as if it was an empty seat
		// Example
		// Wave("hello") => [ "Hello", "hEllo", "heLlo", "helLo", "hellO"]
		// There are already some unit tests for this function
		public static List<string> Wave(string input)
		{
			List<string> wave = [];
			for (int i = 0; i<input.Length; i++)
			{
				StringBuilder sb = new(input); // Easy to change a string using a string builder
				if (!char.IsWhiteSpace(sb[i]))
				{
					sb[i] = char.ToUpper(sb[i]); // Can access the string builder by index
					wave.Add(sb.ToString());
				}				
			}
			return wave;
		}

		// 2: Hello character codes - Convert to integer character codes
		// Convert the word hello to its character codes (one integer for each code) and output them.
		// Do this for hello in Chinese as well.
		// In your output message you may wish to use nihao as 你好 may not print to the console
		// Test this procedure by calling it from main
		public static void WriteHelloCharacterCodes()
		{
			Write("Hello", "Hello");
			Write("你好", "Nihao");
		}

		private static void Write(string input, string message)
		{
			Console.Write($"{message} is :");
			foreach (char c in input)
			{
				Console.Write($"{(int)c} ");
			}
			Console.WriteLine();
		}

		// 3: Hello character codes - Convert to a byte array
		// Convert the word hello to its character codes expressed as a byte array
		// You can use Encoding.Default.GetBytes() for this
		// Output the result
		// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
		// Do this for hello in Chinese as well
		// In your output message you may wish to use nihao as 你好 may not print to the console
		// What difference do you see with your answer to question 3?
		// Test this procedure by calling it from main
		public static void WriteHelloAsBytes()
		{
			string hello = "Hello";
			byte[] helloBytes = Encoding.Default.GetBytes(hello);
			Console.Write("Hello is :");
			Console.WriteLine(string.Join(",", helloBytes));

			string nihao = "你好";
			byte[] nihaoBytes = Encoding.Default.GetBytes(nihao);
			Console.Write("nihao is :");
			Console.WriteLine(string.Join(",", nihaoBytes));

			Console.WriteLine();
		}


		// 4. Character codes - convert integer character codes to a string
		// Given an array of integers where each one represents a character code return the string
		// Use a StringBuilder in case you get a long int array as input
		// There are already some unit tests for this function
		public static string ReadCharacterCodes(int[] codes)
		{
			StringBuilder sb = new();
			foreach (char code in codes)
			{
				sb.Append(code);
			}
			return sb.ToString();
		}

		// 5. Character codes - convert character codes given as a byte array to a string
		// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
		// To test, the byte array: [ 206, 188, 206, 174, 206, 187, 206, 191 ] represents the string μήλο
		// Write unit tests for this function
		public static string ReadCharacterCodes(byte[] codes)
		{			
			return Encoding.Default.GetString(codes);
		}

		// 6. Anagram
		// Given a word and a list of words return the number of words that are anagrams of the others
		// Anagram("star", [ "rats", "arts", "arc" ]) => 2
		// Write unit tests for this function
		public static int Anagram(string input, string[] possibleAnagrams)
		{
			string sorted = SortString(input);
			int count = 0;
			foreach (string value in possibleAnagrams )
			{
				string sortedValue = SortString(value);
				if (sorted.Equals(sortedValue))
				{
					count++;
				}
			}
			return count;
		}

		private static string SortString(string input)
		{
			char[] charArray = input.ToLower().ToCharArray();
			Array.Sort(charArray);
			return new string(charArray);
		}

		// 7. Variable Name helper
		public enum VariableNameType
		{
			CamelCase,
			PascalCase,
			SnakeCase
		}
		// Return the string in either camelCase, PascalCase or snake_case depending on the user choice
		// You can assume the input is currently written in the normal way with spaces between words
		// E.g Cost of cakes => costOfCakes, CostOfCakes or cost_of_cakes depending on the option chosen
		// Write unit tests for this function
		public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
		{
			string[] words = input.Split();
			for (int i = 0; i < words.Length; i++)
			{
				words[i] = words[i].ToLower();
				if ((i > 0 && caseNeeded == VariableNameType.CamelCase) || caseNeeded == VariableNameType.PascalCase)
				{
					// make first letter a capital
					StringBuilder newWord = new(words[i]);
					newWord[0] = char.ToUpper(newWord[0]);
					words[i] = newWord.ToString();
				}
			}
			string delimiter = caseNeeded == VariableNameType.SnakeCase ? "_" : string.Empty;
			return string.Join(delimiter, words);
		}


		// 8: Pig Latin
		// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
		// Leave punctuation marks untouched.
		// If any words entirely consist of punctuation marks you should leave them unchanged
		// The cat sat on the mat. => heTay atcay atsay noay hetay atmay.
		// The string function Split may be useful
		// There are already some unit tests for this function
		public static string PigLatin(string input)
		{
			string[] words = input.Split(' ');
			for (int i = 0; i < words.Length; i++)
			{
				int wordEnd = FindLastIndexNotPunctuation(words[i]);
				int firstLetter = FindFirstIndexNotPunctuation(words[i]);
				if (wordEnd != -1)
				{
					string newWord = words[i].Insert(wordEnd + 1, words[i][firstLetter] + "ay");
					newWord = newWord.Remove(firstLetter, 1);
					words[i] = newWord;
				}
			}
			return string.Join(" ", words);
		}

		private static int FindLastIndexNotPunctuation(string input)
		{
			for (int i = input.Length - 1; i >= 0; i--) // Backwards through loop
			{
				if (!char.IsPunctuation(input[i]))
				{
					return i;
				}
			}
			return -1;
		}

		private static int FindFirstIndexNotPunctuation(string input)
		{
			for (int i = 0; i < input.Length; i++) // Forwards through loop
			{
				if (!char.IsPunctuation(input[i]))
				{
					return i;
				}
			}
			return -1;
		}

		// 9: TV Remote (Extension)
		// Consider the search screen pictured below
		// a b c d e
		// f g h i j
		// k l m n o
		// p q r s t
		// u v w x y
		// z _ <
		// The TV remote has buttons to move up, down, left, right and select
		// It always starts in the top left corner at the 'a' button
		// Write a function that will take a list of words
		// It will return the number of key presses required to enter the words
		// The space key is indicated with a _
		// The enter key is indicated with a <
		// All letters can be converted to lower case 
		// Each word must be separated by a space _
		// Each entry must end with the enter key < being pressed
		// You can assume that the strings do not contain any symbols that are not on the screen or _ or < symbols
		// So for example to enter ET would take 14 key presses
		// b,c,d,e,press e,j,o,t,press t,y,x,w,<,press <
		// War and Peace would take 79 key presses
		// Hint: decompose the problem into sub programs
		// Write unit tests for the problem. 

		private const string Screen = "abcdefghijklmnopqrstuvwxyz_<";
		private const int Width = 5;

		public static int CalculateKeyPresses(List<string> words)
		{
			int count = 0;
			char currentLetter = 'a';
			string wordList = string.Join("_", words); // Add the spaces between words
			wordList += "<"; // Add the enter to the end
			wordList = wordList.ToLower(); // Make sure everything is lowercase
			foreach (char letter in wordList)
			{
				count += CalculateLetterMoves(currentLetter, letter);
				currentLetter = letter;
			}
			return count;
		}

		private static int CalculateLetterMoves(char startLetter, char endLetter)
		{
			int startIndex = Screen.IndexOf(startLetter);
			int endIndex = Screen.IndexOf(endLetter);
			// Number of moves is the row difference + the column difference + the key press
			int numMoves = GetRowDifference(startIndex, endIndex) + GetColumnIndex(startIndex, endIndex) + 1;
			return numMoves;
		}

		private static int GetRowDifference(int startIndex, int endIndex)
		{
			int startRow = startIndex / Width; // Integer division will give the row index
			int endRow = endIndex / Width;
			int rowDiff = Math.Abs(startRow - endRow);
			return rowDiff;
		}

		private static int GetColumnIndex(int startIndex, int endIndex)
		{
			int startCol = startIndex % Width; // Finding the remainder will give the column index
			int endCol = endIndex % Width;
			int colDiff = Math.Abs(startCol - endCol);
			return colDiff;
		}
	}
}
