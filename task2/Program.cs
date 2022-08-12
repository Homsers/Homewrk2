Console.WriteLine("Enter a number");
int number0 = int.Parse(Console.ReadLine());
Console.WriteLine(number0 / 100 == 0 ? "EROR!!!!!!!!!!!!!!!!!.Please enter a three or more digit number" : number0);
int number1 = number0 / 100;
int number2 = number1 % 10;

Console.WriteLine($" The third digit of the number is: {number2}");