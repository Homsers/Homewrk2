Console.Write("Enter a number from 1 to 7: ");
int number0 = int.Parse(Console.ReadLine());

void Days (int number0) 
{
  if (number0 == 6 || number0 == 7) 
  {
  Console.WriteLine("Weekend");
  }
  else if (number0 < 1 || number0 > 7)
  {
    Console.WriteLine("Error!!!!!!!! Please, Enter a number from 1 to 7:");
  }
  else Console.WriteLine("Working day");
}

Days(number0);