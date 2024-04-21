using TMPro;
using UnityEngine;

public class Trader : MonoBehaviour
{
    private ISkinReaction _skinReaction;
    [SerializeField] private Player _player;
    [SerializeField] public TMP_Text _dialogue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CapsuleCollider collider))
        {
            if (_player._skin == Player.Skins.Warrior) _skinReaction = new WarriorReaction();
            if (_player._skin == Player.Skins.Bandit) _skinReaction = new BanditReaction();
            if (_player._skin == Player.Skins.Citizen) _skinReaction = new CitizenReaction();

            _skinReaction.Greeting(_dialogue);
            _skinReaction.DoSmth();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out CapsuleCollider collider))
        {
            _skinReaction = new NoReaction();
            _skinReaction.Greeting(_dialogue);
            _skinReaction.DoSmth();

        }
    }

}
