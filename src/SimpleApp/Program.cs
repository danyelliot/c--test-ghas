using SimpleApp;

var calculator = new Calculator();
Console.WriteLine("Simple Calculator Demo");
Console.WriteLine($"Add: 5 + 3 = {calculator.Add(5, 3)}");
Console.WriteLine($"Subtract: 10 - 4 = {calculator.Subtract(10, 4)}");
Console.WriteLine($"Multiply: 6 * 7 = {calculator.Multiply(6, 7)}");
Console.WriteLine($"Divide: 20 / 4 = {calculator.Divide(20, 4)}");

var greeter = new Greeter();
Console.WriteLine(greeter.Greet("World"));
