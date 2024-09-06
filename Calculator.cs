// See https://aka.ms/new-console-template for more information
//Title
Console.WriteLine("Welcome to my simple Calculator");
//Console.WriteLine("");
//Console.WriteLine("");


//first number input
Console.WriteLine("Please input first number");
string userInput1 = Console.ReadLine();
int userNumber1 = int.Parse(userInput1);

//second number input
Console.WriteLine("Please input second number");
string userInput2 = Console.ReadLine();
int userNumber2 = int.Parse(userInput2);

//Verified parsing works
//Console.WriteLine(userNumber1 + userNumber2);

//Calulator buttons add
Console.WriteLine("Please select which calulation operation");
Console.WriteLine("Press A to Add");
Console.WriteLine("Press S to Subtract");
Console.WriteLine("Press M to Multiply");

//Takes the users choices
string inputLetter = Console.ReadLine();

//Need to insert the variable in the if/else statement so it can be used. 
//Calulaotr Buttons backend caps
int CalculationButton(int userNumber1, int userNumber2, string inputLetter)
{
    if (inputLetter == "A" || inputLetter == "a")
    {
        return userNumber1 + userNumber2;
    }
    else if (inputLetter == "S" || inputLetter == "s")
    {
        return userNumber1 - userNumber2;
    }
    else if (inputLetter == "M" || inputLetter == "m")
    {
        return (userNumber1 * userNumber2);
    }
    Console.WriteLine("Invalid operation selection");
    return 0;
}

//Calulation to the console using the method created
Console.WriteLine($"Your value is {CalculationButton(userNumber1, userNumber2, inputLetter)}");

Console.WriteLine("Press Any Key to Close");

//Console.ReadKey();
