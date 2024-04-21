using UnityEngine;

public class BehaviourMenu : MonoBehaviour
{
    [SerializeField] private Player _player;
 
    public void TakeBanditSkin()
    {
        _player._skin = Player.Skins.Bandit;
 
    }

    public void TakeWarriorSkin()
    {
        _player._skin = Player.Skins.Warrior;

    }
    public void TakeCitizenSkin()
    {
        _player._skin = Player.Skins.Citizen;

    }
}
