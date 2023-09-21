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
        Health.text = "ü�� : " + playerdata.Health;
        Attack.text = "���ݷ� : " + playerdata.Attack;
        Defence.text = "���� : " + playerdata.Defence;
        Critical.text = "ġ��Ÿ : " + playerdata.Critical;
    }

    private void Start()
    {
        ShowStatus();
    }
}
