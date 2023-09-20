using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    // 아이템 종류 : 자원, 장비, 소비 아이템
    Weapon,
    Shield,
    Armor
}

[System.Serializable]

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    public string displayName;
    public string description;
    public int damage;
    public int defence;
    public ItemType type;
    public Sprite icon;
}
