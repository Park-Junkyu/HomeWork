using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itembutton : MonoBehaviour
{
    public GameObject ItemInfo;
    public GameObject IsEquip;
    public GameObject Character;
    private void Awake()
    {

    }
    public void equipItem()
    {
        IsEquip.SetActive(true);
    }
   public void closeInfo()
    {
        ItemInfo.SetActive(false);
        Character.SetActive(true);
    }
}
