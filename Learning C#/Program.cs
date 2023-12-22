//Console.WriteLine("Hello World!");
Console.WriteLine("Congratulations!");
Console.WriteLine(" ");
Console.WriteLine("You wrote your first lines of code.");
//The period is called ember access operator; it`s how you navigate
//from the class to one of its methods. While 'WriteLine' is a method. And
//finally, the 'Console' is the class in which the method writeline is called
//to print the words that we want.
//Remember: WriteLine() method prints the output with a new line after it, while
//Write() won't.
Console.WriteLine("This is the first line.");
Console.Write("This is ");
Console.Write("the second ");
Console.Write("line.");
//Using both techniques, this is what we get.
//------------------------------------------------------Second Lesson
//A single quotation '' creates a character literal while a double quotation ""
//creates a "string" data type, so running only b on the project will output a single character literal
//I will add a new line do differentiate the lesson before from the second lesson
Console.WriteLine("\n");
Console.WriteLine('b');
//If you enter Console.WriteLine('Hello World!'); you will get the error
//too many characters in a character literal.
//If you want to display a number, you can use a int literal.
//The term int is short for integer, and you can do like this:
Console.WriteLine(123);
//We got the output 123 because 123 is neither a character literal or a string data type.
//Then we get float typeof literals, they are the decimals, float and doubles.
//Each one of them gives you a degree of precision: float - 6~9 digits; double 15~17 digits
//and decimal 28~29 digits.
//To create a float literal, append the letter F, lower-case or upper-case after the decimal:
Console.WriteLine(0.25F);
//The output will be 0.25
//If you want to write the default, a double, simple write the decimal that you want to output:
Console.WriteLine(3.141516);
//And if you want to write a decimal, append M or m to the number that you want to output:
Console.WriteLine(12.38781723723427M);
//This will give you a decimal, the highest precision type of decimal literal.
//Notice like how they all give you a new-line "\n" after outputing it.