// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Let's learn C#");
Console.WriteLine("I want a hot beverage too !");
Console.Beep(); // Beep method will makes a sound once the above three lines are executed
Console.WriteLine("Single line comment starts with double slash");
Console.WriteLine("Multiline comments starts with /* and ends with */");
Console.WriteLine("Escape characters are below: ");
Console.WriteLine("\\t is for tab");
Console.WriteLine("\\b is for backspace ");
Console.WriteLine("\\n is for new line");

/* Variables & data types. Creating a variable takes two steps
 * Declaration & Initialization
 */
string fullName = "Srikanth Vadapalli";
Console.WriteLine("My name is " + fullName);

int age;//Declaration
age = 34; //initialization
Console.WriteLine("My age is " + age);
double weight = 94.2;
Console.WriteLine("My weight is " + weight);
bool alive = true;
Console.WriteLine("Are you alive: " + alive);
char symbol = '$';
Console.WriteLine("Your symboll is " + symbol);
Console.WriteLine("Your username is " + symbol + fullName + symbol);

// Constants - Immutable values which are known at compile time and do not change for the life of the program

const double pi = 3.14159;

//Type casting = Converting a value to a different data type. Useful when we accept user input (string). Different data types can do different things
double a = 3.14567;
int b = Convert.ToInt32(a);
Console.WriteLine(b);
Console.WriteLine(a.GetType());
Console.WriteLine(Convert.ToDouble(b)+" is a double: "+Convert.ToDouble(a).GetType());
Console.WriteLine(Convert.ToString(a) + " is a String: "+ Convert.ToString(a).GetType());

Console.ReadKey();

