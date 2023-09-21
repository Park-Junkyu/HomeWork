using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatus : MonoBehaviour
{
    //[SerializeField]
    //private PlayerData playerdata;
    //public PlayerData PlayerData { set { playerdata = value; } }

    public Text Health;
    public Text Attack;
    public Text Defence;
    public Text Critical;

    PlayerData playerdata;

    private void ShowStatus()
    {
        playerdata = DataManager.Instance.playerData[0];
        Health.text = "체력 : " + playerdata.Health;
        Attack.text = "공격력 : " + playerdata.Attack;
        Defence.text = "방어력 : " + playerdata.Defence;
        Critical.text = "치명타 : " + playerdata.Critical;
    }

    private void Start()
    {
        ShowStatus();
    }
}
