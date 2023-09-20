using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    // ������ ���� : �ڿ�, ���, �Һ� ������
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
