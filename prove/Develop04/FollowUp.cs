public class FollowUpQuestion
{
    public List<string> _followUpQuestions = new List<string>();

    public FollowUpQuestion()
    {
        AddFollowUpQuestion();
    }

    public void AddFollowUpQuestion()
{
    _followUpQuestions.Add("Why was this experience meaningful to you?");
    _followUpQuestions.Add("Have you ever done anything like this before?");
    _followUpQuestions.Add("How did you get started?");
    _followUpQuestions.Add("How did you feel when it was complete?");
    _followUpQuestions.Add("What made this time different than other times when you were not as successful?");
    _followUpQuestions.Add("What is your favorite thing about this experience?");
    _followUpQuestions.Add("What could you learn from this experience that applies to other situations?");
    _followUpQuestions.Add("What did you learn about yourself through this experience?");
    _followUpQuestions.Add("How can you keep this experience in mind in the future?");
}


  public string RandomFollowUpQuestion(){
    Random _random = new Random();
    var randomNumber = _random.Next(0, _followUpQuestions.Count);
    return _followUpQuestions[randomNumber];
  }
}