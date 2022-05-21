using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    public static int listCount = 0;
    public static int clueCount = 0;
    public static bool isStartGame;

    [SerializeField] private GameObject[] clone;


    void Update()
    {
        Debug.Log("ClueCount => " + clueCount);
        IsObjectOn();
    }

    private void IsObjectOn()
    {
        if (!isStartGame)
            return;

        for (int i = 0; i < DataController.clueCount; i++)
        {
            clone[i].SetActive(true);
        }
    }

    public void ClueCountUp(int value)
    {
        clueCount = value;
    }

    public void StartGame()
    {
        isStartGame = true;
    }

}
