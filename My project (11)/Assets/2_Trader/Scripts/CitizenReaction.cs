using TMPro;

public class CitizenReaction : ISkinReaction
{
    public void DoSmth()
    {
        
    }

    public void Greeting(TMP_Text greeting)
    {
        greeting.text = "Hello there. I have fresh vegetables. Look here";
    }
}
