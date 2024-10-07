using CSharpStringExercises.Classes;

namespace CSharpStringExercises.Tests
{
	[TestClass]
	public class TestStringExercises
	{
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

        // The first test has been written for you
        // You will need to write the other tests yourself
        // Tests are needed for questions 2,5,6,7,8 and the extension 9.

        [TestMethod]
        [DataRow(new string[] { "0", "hello", "joseph", "joestar", "helo", "lloh" })]
        [DataRow(new string[] { "1", "hello", "hello" })]
        [DataRow(new string[] { "2", "hello", "ohell", "lleho" /*is this actually a word*/, "ohellno" })]
        [DataRow(new string[] { "1", "barc" /*is this actually a word*/, "crab" })]
        [DataRow(new string[] { "0", "bard", "crab" })]
        [DataRow(new string[] { "2", "bard", "drab", "crab", "brad" })]
        [DataRow(new string[] { "2", "star", "rats", "arts", "arc" })]
        public void TestAnagrams(string[] io)
        {
            // data row format:
            // io[0] = output, as a string to be cast to an int with int.Parse
            // io[1] = input 1, as a string as expected by StringExercises.Anagram
            // io[2..] = input 2, as an array as expected by StringExercises.Anagram
            Assert.AreEqual(StringExercises.Anagram(io[1], io[2..]), int.Parse(io[0]));
        }

        [TestMethod]
        [DataRow("camel case", "0", "camelCase")]
        [DataRow("pascal Case", "1", "PascalCase")]
        [DataRow("Snake Case", "2", "snake_case")]
        [DataRow("foo", "0", "foo")]
        [DataRow("bar", "1", "Bar")]
        [DataRow("baz", "2", "baz")]
        [DataRow("Never Gonna Give You Up", "0", "neverGonnaGiveYouUp")]
        [DataRow("Never Gonna Give You Up", "1", "NeverGonnaGiveYouUp")]
        [DataRow("Never Gonna Give You Up", "2", "never_gonna_give_you_up")]
        public void TestVariableNames(string variable_name, string variable_case, string expected)
        {
            // data row format:
            // variable_name = input 1, as a string as expected by StringExercises.WriteVariableName
            // variable_case = input 2, as a string to be cast to an int with int.Parse, to then be cast to StringExercises.VariableNameType as expected by StringExercises.WriteVariableName
            // expected = output, as a string
            Assert.AreEqual(StringExercises.WriteVariableName(variable_name, (StringExercises.VariableNameType)int.Parse(variable_case)), expected);
        }

        [TestMethod]
        [DataRow(new string[] { "14", "ET" })]
        [DataRow(new string[] { "25", "The" })]
        public void TestRemoteKeypresses(string[] io)
        {
            // first element in array is output, everything else is input
            Assert.AreEqual(StringExercises.CalculateKeyPresses(io[1..].ToList()), int.Parse(io[0]));
        }
    }
}