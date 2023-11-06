public class ListingPrompt
{
  private List<string> _listingPrompts = new List<string>();


public ListingPrompt()
{
  InitListingPrompts();
}
    private void InitListingPrompts()
    {
      _listingPrompts.Add("---- Who are people that you appreciate? ----");
      _listingPrompts.Add("---- What are personal strengths of yours? ----");
      _listingPrompts.Add("---- Who are people that you have helped this week? ----");
      _listingPrompts.Add("---- When have you felt the Holy Ghost this month? ----");
      _listingPrompts.Add("---- Who are some of your personal heroes? ----");
    }

  public string RandomListingPrompt(){
    Random _random = new Random();
    var randomNumber = _random.Next(0, _listingPrompts.Count);
    return _listingPrompts[randomNumber];
  }
}