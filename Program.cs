
Console.Write("Enter first number: ");
int firstNumber=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter operation(+,-,*,/,%): ");
string operation= Console.ReadLine();
Console.Write("Enter second number: ");
int secondNumber=Convert.ToInt32(Console.ReadLine());;

//Calculator
Console.WriteLine($"Adding: {firstNumber+secondNumber}");
Console.WriteLine($"Subscring: {firstNumber-secondNumber}");
Console.WriteLine($"Multiplication: {firstNumber*secondNumber}");
Console.WriteLine($"Dividing: {firstNumber/secondNumber}");

Console.WriteLine("************************************************");
//Tech Comparision
Console.WriteLine($"1st number is greater than 2nd number: {firstNumber>secondNumber}");
Console.WriteLine($"2nd number is greater than 1st number: {firstNumber<secondNumber}");
Console.WriteLine($"1st number is equal to 2nd number: {firstNumber==secondNumber}");
Console.WriteLine($"1st number is not equal to 2nd number: {firstNumber!=secondNumber}");

Console.WriteLine("************************************************");
//Ternar [ ? : ]
string message =
    firstNumber>=0 && secondNumber>0 
         ? "1st and 2nd numbers are positive "
         : "1st and 2nd numbers are negative ";

Console.WriteLine(message);
Console.WriteLine("************************************************");
//Logical Operator
string message1 =
    firstNumber>=0 || secondNumber>0 
         ? "1st and 2nd numbers are positive "
         : "1st and 2nd numbers are negative ";

Console.WriteLine(message1);
string message2 =
    !(firstNumber>=0 )
         ? "1st number is not positive "
         : "1st numbers is not negative ";

Console.WriteLine(message2);

Console.WriteLine("************************************************");

//Condition
if(firstNumber>secondNumber)
{ Console.WriteLine("1st number is greater than 2nd number"); }
if(firstNumber<secondNumber)
{ Console.WriteLine("2nd number is greater than 1st number"); }
if(firstNumber==secondNumber)
{ Console.WriteLine("1st number is equal to 2nd number"); }

Console.WriteLine("Switch ");

// Switch 
switch(operation)
{
    case "+": Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
    break;
    case "-": Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber-secondNumber}");
    break;
    case "*": Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber*secondNumber}");
    break;
    case "/": Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber/secondNumber}");
    break;
    case "%": Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber%secondNumber}");
    break;
    default: Console.WriteLine("Operation not found");
    break;
}
Console.WriteLine("Switch expressions");

// Switch expressions
string result =operation switch
{
   "+"=>$"{firstNumber}+{secondNumber}={firstNumber+secondNumber}",
   "-"=> $"{firstNumber}-{secondNumber}={firstNumber-secondNumber}",
   "*"=>$"{firstNumber}-{secondNumber}={firstNumber-secondNumber}",
   "/"=> $"{firstNumber}-{secondNumber}={firstNumber-secondNumber}",
   "%"=>$"{firstNumber}-{secondNumber}={firstNumber-secondNumber}",
   _  => "Operation not found"

};
Console.WriteLine(result);



Console.WriteLine("Loop");
// Loop-aylanish
Console.WriteLine("while-Loop");
if(firstNumber>0)
{
    int counter=0;
    while(counter<firstNumber)
    {
        Console.WriteLine(counter);
        counter++;
    }
}

Console.WriteLine("do-while-Loop");
string password="";
do{

    Console.WriteLine("Enter password : ");
    password=Console.ReadLine();
} while(password!="pa$$w0rd");

for(int iterator=1;iterator<=10;iterator++)
{
    
    for(int innerIterator=1;innerIterator<=10;innerIterator++)
    {
        Console.WriteLine($"{iterator}*{innerIterator}={iterator*innerIterator}");

    }
    Console.WriteLine();
}