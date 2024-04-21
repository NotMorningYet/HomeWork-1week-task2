using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Trader _trader;
    void Awake()
    {
        _player._skin = Player.Skins.Warrior;

    }


}
