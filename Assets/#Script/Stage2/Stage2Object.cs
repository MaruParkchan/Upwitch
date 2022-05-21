using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Object : MonoBehaviour
{
    public GameObject[] clone;
    public int value = 0;
    private void Awake()
    {
        for (int i = 0; i < clone.Length; i++)
            clone[i].SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            value++;
        }

        if(clone[value].activeSelf == true)
        {
            Debug.Log("활성화 -> " + clone[value].name);
        }
    }
}
