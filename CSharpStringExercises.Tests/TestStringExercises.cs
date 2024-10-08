using CSharpStringExercises.Classes;

namespace CSharpStringExercises.Tests
{
	[TestClass]
	public class TestStringExercises
	{
		// Tests have been written for Q1 Mexican Wave, Q4 Character codes and Q8 Pig Latin
		// You will need to write the other tests yourself
		// Tests are needed for questions 5,6,7 and the extension 9.
		[TestMethod]
		public void TestWave()
		{
			string input = "hello";
			List<string> output = ["Hello", "hEllo", "heLlo", "helLo", "hellO"];
			List<string> result = StringExercises.Wave(input);
			CollectionAssert.AreEqual(output, result);
		}

		[TestMethod]
		public void TestWaveWithSpace()
		{
			string input = "good day";
			List<string> output = ["Good day", "gOod day", "goOd day", "gooD day", "good Day", "good dAy", "good daY"];
			List<string> result = StringExercises.Wave(input);
			CollectionAssert.AreEqual(output, result);
		}

		[TestMethod]
		[DataRow(new int[] { 104, 101, 108, 108, 111 }, "hello")]
		[DataRow(new int[] { 20320, 22909 }, "你好")]
		[DataRow(new int[] { 956, 942, 955, 959 }, "μήλο")]
		public void TestReadCharacterCodesInt(int[] input, string output)
		{
			string result = StringExercises.ReadCharacterCodes(input);
			Assert.AreEqual(output, result);
		}

		[TestMethod]
		[DataRow(new byte[] { 104, 101, 108, 108, 111 }, "hello")]
		[DataRow(new byte[] { 228, 189, 160, 229, 165, 189 }, "你好")]
		[DataRow(new byte[] { 206, 188, 206, 174, 206, 187, 206, 191 }, "μήλο")]
		public void TestReadCharacterCodesByte(byte[] input, string output)
		{
			string result = StringExercises.ReadCharacterCodes(input);
			Assert.AreEqual(output, result);
		}

		[TestMethod]
		[DataRow("star", new string[] { "rats", "arts", "arc" }, 2)]
		[DataRow("analogue", new string[] { "analogue", "naalogue", "nnalogue" }, 2)]
		[DataRow("kart", new string[] { "kaat", "artk", "art" }, 1)]
		public void TestAnagram(string input1, string[] input2, int output)
		{
			int result = StringExercises.Anagram(input1, input2);
			Assert.AreEqual(output, result);
		}

		[TestMethod]
		[DataRow("Cost of Cakes", StringExercises.VariableNameType.CamelCase, "costOfCakes")]
		[DataRow("Cost of Cakes", StringExercises.VariableNameType.PascalCase, "CostOfCakes")]
		[DataRow("Cost of Cakes", StringExercises.VariableNameType.SnakeCase, "cost_of_cakes")]
		public void TestVariableCases(string input1, StringExercises.VariableNameType input2, string output)
		{
			string result = StringExercises.WriteVariableName(input1, input2);
			Assert.AreEqual(output, result);
		}

		[TestMethod]
		[DataRow("A lovely day", "Aay ovelylay ayday")]
		[DataRow("Grab the doughnuts, now!", "rabGay hetay oughnutsday, ownay!")]
		[DataRow("You aren't making sense &,%%!", "ouYay ren'taay akingmay ensesay &,%%!")]
		[DataRow("The cat sat on the mat.", "heTay atcay atsay noay hetay atmay.")]
		[DataRow("\"How lovely to see you?\", said the lady.", "\"owHay ovelylay otay eesay ouyay?\", aidsay hetay adylay.")]
		public void TestPigLatin(string input, string output)
		{
			string result = StringExercises.PigLatin(input);
			Assert.AreEqual(output, result);
		}


		[TestMethod]
        [DataRow(new string[] { "ET" }, 14)]
        [DataRow(new string[] { "The" }, 25)]
		[DataRow(new string[] { "War", "and", "Peace" }, 79)]
		public void TestRemoteKeypresses(string[] input, int output)
        {
            Assert.AreEqual(output, StringExercises.CalculateKeyPresses(input.ToList()));
        }
    }
}