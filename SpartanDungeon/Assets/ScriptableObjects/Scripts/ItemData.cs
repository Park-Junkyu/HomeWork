using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    // 아이템 종류 : 자원, 장비, 소비 아이템
    Resource,
    Equipable,
    Consumable
}

public enum ConsumableType
{
    Hunger,
    Health
}

[System.Serializable]

public class ItemDataConsumable
{
    public ConsumableType type;
    public float value;
}
[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Consumable")]
    public ItemDataConsumable[] consumables;
}
