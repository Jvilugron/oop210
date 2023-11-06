public class Prompt
{
  public List<string> _promptsList = new List<string>();


public Prompt()
  {
    initialPrompt();
  }

     public void initialPrompt()
    {
        _promptsList.Add("---- Think of a time when you stood up for someone else. ----");
        _promptsList.Add("---- Think of a time when you did something really difficult. ----");
        _promptsList.Add("---- Think of a time when you helped someone in need. ----");
        _promptsList.Add("---- Think of a time when you did something truly selfless. ----");
       
  }


    public string GetRandomPrompt(){
    Random _random = new Random();
    var randomNumber = _random.Next(0, _promptsList.Count);
    return _promptsList[randomNumber];
  }


}