using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public ItemData[] itemdata;
    public PlayerData[] playerData;

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
