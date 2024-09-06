// See https://aka.ms/new-console-template for more information
//Title
Console.WriteLine("Welcome to my simple Calculator");
Console.WriteLine("");
Console.WriteLine("");


//first number input
Console.WriteLine("Please input first number");
string userInput1 = Console.ReadLine();
int userNumber1 = int.Parse(userInput1);

//second number input
Console.WriteLine("Please input second number");
string userInput2 = Console.ReadLine();
int userNumber2 = int.Parse(userInput2);

//Calulator buttons add
Console.WriteLine("Please select which calulation operation");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

//
string calculationInput = Console.ReadLine();


//Calulaotr Buttons backend caps
string Calculation(string input)
{
    if( input == "A" || input == "a")
    {
        return ;
    }
}


Console.ReadKey();


