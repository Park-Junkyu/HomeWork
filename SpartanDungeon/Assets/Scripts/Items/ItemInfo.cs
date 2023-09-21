using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemInfo : MonoBehaviour
{
    [SerializeField]
    private ItemData itemdata;
    public ItemData ItemData { set {itemdata  = value; } }

    public Text ItemName;
    public Text ItemOption;
    public Text ItemDescription;
    Image ItemIcon;

    private void Awake()
    {
        ItemIcon = GetComponentInChildren<Image>();
    }

    private void Start()
    {
        ShowItem();
    }
    void ShowItem()
    {
        ItemName.text = itemdata.displayName;
        ItemDescription.text = itemdata.description;
        if (itemdata.type.ToString() == "Weapon")
        {
            ItemOption.text = "공격력 : " + itemdata.damage.ToString();
        }else if(itemdata.type.ToString() == "Armor" || itemdata.type.ToString() == "Shield")
        {
            ItemOption.text = "방어력 : " + itemdata.defence.ToString();
        }
        ItemIcon.sprite = itemdata.icon;
    }
}
