//write your console display in here

using System;

public class Comandante
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        string operation = "";
        
        while(operation != "="){
            Console.WriteLine ("Enter first number: ");
            int firstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Enter second number: ");
            int secondInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Choose operation (+, -, *, /, %, =): ");
            operation = Console.ReadLine();
            if(operation == "=") {
                Console.WriteLine("Program Terminated");
            };
            
            switch(operation){
                case "+":
                    Console.WriteLine(calc.Calculate(firstInput, secondInput, operation));
                    break;
                case "-":
                    Console.WriteLine(calc.Calculate(firstInput, secondInput, operation));
                    break;
                case "*":
                    Console.WriteLine(calc.Calculate(firstInput, secondInput, operation));
                    break;
                case "/":
                         Console.WriteLine(calc.Calculate(firstInput, secondInput, operation));
                    break;
                case "%":
                    Console.WriteLine(calc.Calculate(firstInput, secondInput, operation));
                    break;
                default:
                    Console.WriteLine("Incorrect Operation Used, please try again");
                    break;
            }
            
        
        
        }
    }
}
