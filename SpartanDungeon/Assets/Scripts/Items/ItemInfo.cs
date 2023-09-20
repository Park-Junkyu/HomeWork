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
        ItemOption.text ="공격/방어력 : "+ itemdata.damage.ToString();
        ItemIcon.sprite = itemdata.icon;
    }
}
