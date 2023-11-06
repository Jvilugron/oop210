public class Listing : Structure
{
private List<string> _listingResponses = new List<string>();
public Listing( string activityName, string activityDescription) : base(activityName, activityDescription)

{

   
}


public void GetRandomPromptForListing()
{
  ListingPrompt listingPrompt = new ListingPrompt();
  Console.WriteLine($" ");
  Console.WriteLine($"List as many things as you can think of for the following prompt:");
  
  Console.WriteLine($"{listingPrompt.RandomListingPrompt()}");
  Console.WriteLine($" ");

}


public void CountResponses()
{
    string responseListing = "";
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(secondsUsed);

    Console.WriteLine("Listing time has started! Enter your responses:");

    while (DateTime.Now < futureTime)
    {
       responseListing = Console.ReadLine();
        if(responseListing == ""){
   
    _listingResponses.Remove(responseListing);
        }
        else{
           _listingResponses.Add(responseListing);
        }
       
       
    }
 
   
    Console.WriteLine($"You listed {_listingResponses.Count} things!");
}


}