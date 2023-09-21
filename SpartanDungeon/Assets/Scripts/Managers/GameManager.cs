using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
//using UnityEditor;

public class GameManager : MonoBehaviour
{
    PlayerData playerData;
    //[InitializeOnEnterPlayMode]
    //private void resetPlayerData()
    //{
    //    playerData = DataManager.Instance.playerData[0];
    //    playerData.Health = playerData.MaxHealth;
    //    playerData.Attack = playerData.MaxAttack;
    //    playerData.Defence = playerData.MaxDefence;
    //    playerData.Critical = playerData.MaxCritical;
    //}
    private static GameManager instance;
    public static GameManager Instance
    { 
        get { return instance == null ? null : instance; }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }

    private void Start()
    {
        //playerData = DataManager.Instance.playerData[0];
        //playerData.Health = playerData.MaxHealth;
        //playerData.Attack = playerData.MaxAttack;
        //playerData.Defence = playerData.MaxDefence;
        //playerData.Critical = playerData.MaxCritical;
    }
}


