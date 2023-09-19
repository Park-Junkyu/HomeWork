using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mySceneManager : MonoBehaviour
{
    public string SceneName;
    void Start()
    {
        
    }
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
