public class Structure
{
  private string _activityName;
  private string _activityDescription;
  public int secondsUsed;


public Structure(string activityName, string activityDescription)
{
  _activityName = activityName;
  _activityDescription = activityDescription;

  
} 

  
public void RunSpinnerTwice()
{
  Console.WriteLine($"Get ready...");
  
    for (int j = 0; j < 1; j++)
    {
        for (int i = 0; i < 2; i++)
        {
            LoadingSpinner();
        }
    }
}


public void WelcomeMessage()
{
    Console.WriteLine(" ");
    Console.WriteLine($"Welcome to the {_activityName} Activity!");
    Console.WriteLine(" ");
   
    Thread.Sleep(800);
    Console.WriteLine($"{_activityDescription}");
    Console.WriteLine(" ");
    Thread.Sleep(800);
    Console.Write($"How Long, in seconds, would you like to use {_activityName} for? ");
    secondsUsed = int.Parse(Console.ReadLine() ?? String.Empty);
    Console.Clear();
}
public void LoadingSpinner()
{

    Console.Write("|");
    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("/");
    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("-");
    Thread.Sleep(500);
    Console.Write("\b");
    Console.Write("\\");
    Thread.Sleep(500);
    Console.Write("\b");

    
}
  public void CountDown()
{ 

 

int numberRoundedUp = (int)Math.Ceiling((double)secondsUsed/10);
  RunSpinnerTwice();


  Console.WriteLine(" ");
    for (int j = 0; j < numberRoundedUp; j++)
        {
        Console.Write($"Breathe in..." );
  
  
      
  for (int i = 5; i > 0; i--)
  {
    Console.Write(i );
    Thread.Sleep(1000);
    Console.Write("\b \b") ;

    
  }
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.Write("Breathe out...");

    for (int i = 5; i > 0; i--)
  {
    Console.Write(i );
    Thread.Sleep(1000);
    Console.Write("\b \b") ;
   
  
  }  
     Console.WriteLine(" ");

    }

}
  
public void GoodByeMessage()
{
    Console.WriteLine(" ");
    Console.WriteLine($"Thank you for using the {_activityName} Activity!");
    Console.WriteLine(" ");
    Thread.Sleep(1000);
    Console.WriteLine($"You used {_activityName} for {secondsUsed} seconds. ");
    Thread.Sleep(1000);
    Console.WriteLine(" ");
    LoadingSpinner();
    Thread.Sleep(1000);
    Console.Clear();

 
}
public void PonderBeforeMessage()
{

   Console.Write("You may begin in: ");


    for (int i = 5; i > 0; i--)
  {
    Console.Write(i );
    Thread.Sleep(1000);
    Console.Write("\b \b") ;
   
  
  }  
}

}