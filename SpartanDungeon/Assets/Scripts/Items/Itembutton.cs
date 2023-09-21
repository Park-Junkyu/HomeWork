using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itembutton : MonoBehaviour
{
    public GameObject ItemInfo;
    public GameObject IsEquip;
    public GameObject Character;
    ItemData item;
    PlayerData player;
    private void Awake()
    {
        //itemdata = GetComponentInChildren<ItemData>();
    }

    public void equipItem(int weaponNum)
    {
        item = DataManager.Instance.itemdata[weaponNum];
        player = DataManager.Instance.playerData2;
        if (item.type.ToString() == "Weapon")
        {
            player.Attack += item.damage;
        }
        else if (item.type.ToString() == "Armor" || item.type.ToString() == "Shield")
        {
            player.Defence += item.defence;
        }
        IsEquip.SetActive(true);
    }
    public void closeInfo()
    {
        ItemInfo.SetActive(false);
        Character.SetActive(true);
    }
}
