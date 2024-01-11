// Leo Garcia

// 09/07/2023

// Mini Challenge 2 

// Made a calculator that only does addition problems and nothing more

// Peer Reviewer: 
// Peer's Notes: 



//Initialization
using System.Globalization;
Console.Clear();
string myTitle = "Apple Kid's Addition Calculator";
string breakPoint = "-------------------------------------------";

//Program
Console.WriteLine(myTitle);
Console.WriteLine ("");
Console.WriteLine("Hello, this is my latest invention, the addition calculator. It's a calculator that exclusively does addition problems.");
Console.WriteLine ("Just give this thing two numbers and it will give you the amount that they add to, go on try it yourself");
Console.WriteLine(breakPoint);
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Plus...");
int secondNum = Convert.ToInt32(Console.ReadLine());
int total = firstNum + secondNum;
Console.WriteLine("");
Console.WriteLine($"{firstNum} + {secondNum} = {total}!");
Console.WriteLine("Thank you for using the official Apple Kid Addition Calculator.");
Console.WriteLine("Every feedback, dollar, and food item is very valuable to my productivity, so I would be very grateful if you would generously donate any of what I asked for.");
Console.WriteLine("Ah yes, and I live in the Apple Kid house over in Twoson, Eagleland. Send all donations to that location. Thank you and goodbye.");


