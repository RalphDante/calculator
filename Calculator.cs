using System;

public class Calculator
{
    public double? Calculate(int first, int second, string operation)
    {
        double result = 0;
        switch(operation){
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                result = first / second;
                break;
            case "%":
                result = first % second;
                break;
            default:
                Console.WriteLine("Incorrect Operation Used, please try again");
                break;
        }

        return result;
    }
}

