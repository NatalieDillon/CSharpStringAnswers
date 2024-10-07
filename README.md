# CSharpStringExercises

Please answer the following questions</br>

1: Pig Latin</br>
Move the first letter of each word to the end of it, then add "ay" to the end of the word.</br> 
Leave punctuation marks untouched.</br>
If any words entirely consist of punctuation marks you may disregard them altogether.</br>
The cat sat on the mat. => heTay atcay atsay noay hetay atmay.</br>
The string function Split may be useful.</br>
There are already some unit tests for this function.</br>	

2: Mexican wave</br>
The input string will always be lower case but maybe empty.</br>
If the character in the string is whitespace then pass over it as if it was an empty seat</br>
Example</br>
Wave("hello") => { "Hello", "hEllo", "heLlo", "helLo", "hellO"}</br>
Write unit tests for this function</br>

3: Hello character codes - Convert to integer character codes</br>
Convert the word hello to its character codes (one integer for each code) and output them.</br>
Do this for hello in Chinese as well</br>
Test this procedure by calling it from main</br>
		
4: Hello character codes - Convert to a byte array</br>
Convert the word hello to its character codes expressed as a byte array</br>
You can use Encoding.Default.GetBytes() for this</br>
Output the result</br>
Remember a byte is nothing but an integer between 0-255 that uses one byte of memory</br>
Do this for hello in Chinese as well</br>
What difference do you see with your answer to question 3?</br>
Test this procedure by calling it from main</br>

5: Character codes - convert integer character codes to a string</br>
Given an array of integers where each one represents a character code return the string</br>
To test, the int array { 956 942 955 959 } represents the word for code in Greek</br>
It might not print nicely to the console but you can inspect the variable, use an assert, or write a test</br>
Use a StringBuilder in case you get a long int array as input</br>
Write unit tests for this function</br>

6: Character codes - convert character codes given as a byte array to a string</br>
Remember a byte is nothing but an integer between 0-255 that uses one byte of memory</br>
To test, the byte array: { 206, 188, 206, 174, 206, 187, 206, 191 } represents the word for code in Greek</br>
It might not print nicely to the console but you can inspect the variable, use an assert or write a test</br>
Write unit tests for this function</br>

7: Anagram</br>
Given a word and a list of words return the number of words that are anagrams of the others</br>
Anagram("star", new string[] { "rats", "arts", "arc" }) => 2</br>
Write unit tests for this function</br>

8: Variable Name helper</br>
Return the string in either camelCase, PascalCase or snake_case depending on the user choice</br>
You can assume the input is currently written in the normal way with spaces between words</br>
E.g Cost of cakes => costOfCakes, CostOfCakes or cost_of_cakes depending on the option chosen</br>
Write unit tests for this function</br>

9: TV Remote (Extension)</br>
Consider the search screen pictured below</br>
a b c d e</br>
f g h i j</br>
k l m n o</br>
p q r s t</br>
u v w x y</br>
z _ <</br>
The TV remote has buttons to move up, down, left, right and select</br>
It always starts in the top left corner at the 'a' button</br>
Write a function that will take a list of words</br>
It will return the number of key presses required to enter the words</br>
The space key is indicated with a _</br>
The enter key is indicated with a <</br>
All letters can be converted to lower case</br> 
Each word must be separated by a space _</br>
Each entry must end with the enter key < being pressed</br>
You can assume that the strings do not contain any symbols that are not on the screen or _ or < symbols</br>
So for example to enter ET would take 14 key presses</br>
b,c,d,e,press e,j,o,t,press t,y,x,w,<,press <</br>
War and Peace would take 79 key presses</br>
Hint: decompose the problem into sub programs</br>
Write unit tests for this function.</br> 

