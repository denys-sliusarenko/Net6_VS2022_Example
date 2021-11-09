// See https://aka.ms/new-console-template for more information
global using System.Text; // can use 'global using' before all 'usings' else error
using Net6_VS2022_Example.Core;

Console.WriteLine("Hello, World!");// without main() in C#10



User myUser = new("Chris", 21);
User otherUser = myUser with { Name = "David" };// can use 'with'


TestRec myObj = new("Alex", "Johnson"); //ovveride and inherit ToSting()
Console.WriteLine(myObj.ToString());
// Alex Johnson


InheritedRecord mySecObj = new("Thomas", "Brown");
Console.WriteLine(mySecObj.ToString());
// inheritedRecord { name = Thomas, surname = Brown} without 'sealed'
// with sealed:
// Thomas Brown

// simplification access for nested properties and fields
Console.WriteLine(myObj.TakeFourSymbols(myObj));

// support const string interpolation
const string constStrFirst = "FirstStr";
const string summaryConstStr = $"SecondStr {constStrFirst}";


const char a = 'a';
//const string summaryConstStr2 = $"SecondStr {constStrFirst} {a}"; error with 'char'

Person person = new Person { Name = "Tom", Age = 33 };

(string name, int age) = person;

Console.WriteLine(name);    // Tom
Console.WriteLine(age);     // 33


string model = string.Empty;
(name, var agePerson) = person; //agePerson not initalize, but it works in C#10

Console.ReadKey();
