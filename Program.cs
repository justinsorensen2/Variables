using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      //create var for #cups of coffee I drink daily
      var numberOfCupsOfCoffee = 4;
      //create var for my full name
      var fullName = "Justin Sorensen";
      //create var for today and set to today's date
      DateTime date1 = DateTime.Now;
      var today = date1;
      //console print the above variables on a single line
      Console.WriteLine("My name is " + fullName + ". The date is " + today + ". I've had " + numberOfCupsOfCoffee + " cups of coffee today.");
      //Ask user for name
      Console.WriteLine("What is your name?");
      //Store response in var user
      var user = Console.ReadLine();
      //something special is user is named Alice
      if (user == "Alice")
      {
        Console.WriteLine("Alice, Welcome to Wonderland!");
      }
      else
      {
        // Welcome user with their name
        Console.WriteLine("Welcome, ", user, "!!");
      }
      //Ask user to enter a number store as operand 1
      Console.WriteLine(user + ", please enter a number.");
      var number1 = Console.ReadLine();
      var operand1 = double.Parse(number1);
      //Ask user to enter a second number and store as operand2
      Console.WriteLine(user + ", please enter a second number.");
      var number2 = Console.ReadLine();
      var operand2 = double.Parse(number2);
      //Add operands and save in var sum
      var sum = operand1 + operand2;
      //subtract and save in var difference
      var difference = operand1 - operand2;
      //divide and save in quotient var
      var quotient = operand1 / operand2;
      //multiply and save in product var
      var product = operand1 * operand2;
      //find remainder and save in var remainder
      var remainder = operand1 % operand2;
      //print results to screen in meaningful way
      Console.WriteLine("The sum of these numbers is " + sum);
      Console.WriteLine("The difference between these numbers is " + difference);
      Console.WriteLine("The quotient of these numbers is " + quotient);
      Console.WriteLine("The product of these numbers is " + product);
      Console.WriteLine("The remainder after dividing these numbers is " + remainder);




    }
  }
}
