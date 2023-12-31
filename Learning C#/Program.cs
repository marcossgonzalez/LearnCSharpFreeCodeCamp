﻿//Console.WriteLine("Hello World!");
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
//------------------------------Booleans
//We can alse deal with booleans: true or false. They are called bool literal, as follows:
Console.WriteLine(true);
Console.WriteLine(false);
//They give you the 'bools', as you can see.
//C# is believed, by their designers, to help developers avoid software bugs by
//enforcing data types, a concept that will unfold as we learn more about C#.\
//-----------------------------------------Declare variables
string firstName;
//In this case, you're creating a variable of the type string called firstName.
//Variable name can contain alphanumric characters and underscore. Special
//characters like the hash symbol or the dollar symbol are not allowed.
//Variable names begin with a alphabetical letter or an underscore, but
//not a number. And, for the last part, they can not be a C# keyword like
// decimal, string, bool, and so on.
//Variables should be camel case: string thisIsACamelCaseVariable.
//Let's attribute the first variable:
firstName = "Bob";
//To retrieve the data in the variable, we can use the method WriteLine or Write to view it.
Console.WriteLine(firstName);
//We can also reassign the variable as many time as we want.
Console.WriteLine(firstName);
firstName = "Liem";
Console.WriteLine(firstName);
firstName = "Isabella";
Console.WriteLine(firstName);
firstName = "Yasmin";
Console.WriteLine(firstName);
//We can also assign the variable on the same line like this:
string secondName = "Bazinga";
Console.WriteLine(secondName);
//------------------ Implicitly typed local variables
//We can use the keyword 'var' to create a string "var message = "Hello World"
//and it will act as a string type of data, but if you try to change it
//it will give you an error, for example, if you try to change it to decimal
//the compiler will tell that you cannot implicitly convert type 'decimal' to 'string'
//Also, all the implicitly typed local variables must be initialized in loco:
var message = "This is a message";
//Like this.
Console.WriteLine(message);
//-------------------------Display literal and variable values
var name = "Bob";
int number = 3;
float numberTwo = 34.4F;
Console.Write("Hello, " + name +  "! You have " + number + " messages in your inbox. The temperature is " + numberTwo + " celsius.\n");
//Like this