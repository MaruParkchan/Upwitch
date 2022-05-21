using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DataReset : MonoBehaviour
{
    void Awake()
    {
        DataController.listCount = 0;
        DataController.clueCount = 0;
        DataController.isStartGame = false;
    }

    public void ExitGAME()
    {
        Application.Quit();
    }

}
