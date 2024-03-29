using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Stat : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI countHP;
    [SerializeField]
    public TextMeshProUGUI countDamage;

    private void Start()
    {
        countHP.text = Game.StatusPlayer.HP.ToString();
        countDamage.text = Game.StatusPlayer.Damage.ToString();
    }

    private void OnGUI()
    {
        countHP.text = Game.StatusPlayer.HP.ToString();
        countDamage.text = Game.StatusPlayer.Damage.ToString();
    }
}
