public class Reflecting : Structure
{

private string randomPrompt;
private string randomQuestion;




public Reflecting( string activityName, string activityDescription) : base(activityName, activityDescription)
{


}

public void GetRandomPromptForReflecting()
{
  Prompt prompt = new Prompt();
  randomPrompt = prompt.GetRandomPrompt();
    Console.WriteLine(" ");
  Console.WriteLine($"Consider the following prompt:");
  Console.WriteLine(" ");
  Console.WriteLine(randomPrompt);
   Console.WriteLine(" ");
  Console.WriteLine($"When you have something in mind, press enter to continue.");
   Console.WriteLine(" ");
  // Press enter to continue
  Console.ReadLine();
  Console.Clear();

  
}
public void GetRandomFollowUpQuestion()
{
  FollowUpQuestion _followUpQuestion = new FollowUpQuestion();
  randomQuestion = _followUpQuestion.RandomFollowUpQuestion();
  Console.WriteLine(" ");
  Console.Write($"{randomQuestion} ");
 for (int j = 0; j < 1; j++)
    {
        for (int i = 0; i < 2; i++)
        {
            LoadingSpinner();
        }
    }
}

}