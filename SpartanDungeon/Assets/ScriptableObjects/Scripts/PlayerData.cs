using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Player", menuName = "New Player")]

public class PlayerData : ScriptableObject
{
    //[SerializeField] private int health;
    //public int Health { get { return health; } }
    //[SerializeField] private int attack;
    //public int Attack { get { return attack; } }
    //[SerializeField] private int defence;
    //public int Defence { get { return defence; } }
    //[SerializeField] private int critical;
    //public int Critical { get { return critical; } }
    public int Health;
    public int Attack;
    public int Defence;
    public int Critical;
}
