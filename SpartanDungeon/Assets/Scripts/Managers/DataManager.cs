using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public ItemData[] itemdata;
    public PlayerData[] playerData;
    public PlayerData playerData2;
    private static DataManager instance;
    public static DataManager Instance
    {
        get { return instance == null ? null : instance; }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        playerData2 = new PlayerData();
        playerData2.Health = playerData[0].Health;
        playerData2.Attack = playerData[0].Attack;
        playerData2.Defence = playerData[0].Defence;
        playerData2.Critical = playerData[0].Critical;
    }

    private void Start()
    {

    }

    //public void EquipItem(ItemData item, PlayerData player)
    //{
    //    if(item.type.ToString() == "Weapon")
    //    {
    //        player.Attack += item.damage;
    //    }else if(item.type.ToString() =="Armor" ||  item.type.ToString() == "Shield")
    //    {
    //        player.Defence += item.defence;
    //    }
    //}
}
