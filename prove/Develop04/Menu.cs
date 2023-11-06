public class Menu
{
  public void Display()
  {
    bool quit = false;
    string response = "";
    string[] options = {"1", "2", "3", "4"};

    while(!quit)
    {
      while(options.Contains(response)== false)
      {
        Console.WriteLine(" ");
        
        Console.Write("[1] Go to Breathing Activity\n[2] Go to Reflecting Activity \n[3] Go to Listing Activity \n[4] Quit \n\n What would you like to do? ");
        response = Console.ReadLine() ?? String.Empty;
      } 
      // Clear the console
      Console.Clear();
      switch(response)
      {
        
        case "1":
      Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
      breathing.WelcomeMessage();
      breathing.LoadingSpinner();
      // breathing.RunSpinnerTwice();
      breathing.CountDown();
     breathing.LoadingSpinner();
     Console.Clear();
     breathing.GoodByeMessage();
      break;
      case "2":
      Reflecting reflecting = new Reflecting("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
);
      reflecting.WelcomeMessage();
      reflecting.LoadingSpinner();
      reflecting.RunSpinnerTwice();
      reflecting.GetRandomPromptForReflecting();
    reflecting.PonderBeforeMessage();
      reflecting.GetRandomFollowUpQuestion();
      Console.WriteLine($" ");
      
      reflecting.GetRandomFollowUpQuestion();
      reflecting.GoodByeMessage();
       

      break;
      case "3":
      Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
      listing.WelcomeMessage();
      listing.LoadingSpinner();
      listing.RunSpinnerTwice();
      listing.GetRandomPromptForListing();
      listing.PonderBeforeMessage();
      Console.WriteLine($" ");
      listing.CountResponses();
      listing.GoodByeMessage();
      break;    
      case "4":
      // quit 
      Console.WriteLine($"Goodbye!");
      quit = true;
      break; 
      }
 
      response = "";
    }

  }

}