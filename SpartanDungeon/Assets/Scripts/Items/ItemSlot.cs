using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public GameObject Character;
    public GameObject ItemInfo;

    public void ShowItemInfo()
    {
        Character.SetActive(false);
        ItemInfo.SetActive(true);

    }

}
