using TMPro;

public class NoReaction : ISkinReaction
{
    public void DoSmth()
    {
        
    }

    public void Greeting(TMP_Text greeting)
    {
        greeting.text = "";
    }

}
