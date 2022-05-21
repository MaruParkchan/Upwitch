using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOFF : MonoBehaviour
{
    [SerializeField] private GameObject headTraget;
    [SerializeField] private GameObject bodyTraget;
    [SerializeField] private GameObject upperlimbTarget;
    [SerializeField] private GameObject legTraget;

    [SerializeField] private GameObject[] headObjectList = new GameObject[3];
    [SerializeField] private GameObject[] bodyObjectList = new GameObject[2];
    [SerializeField] private GameObject[] UpperLimbList = new GameObject[3];
    [SerializeField] private GameObject legList;

    private void Update()
    {
        if (headTraget.activeSelf == false)
        {
            for (int i = 0; i < headObjectList.Length; i++)
                headObjectList[i].SetActive(false);
        }

        if (bodyTraget.activeSelf == false)
        {
            for (int i = 0; i < bodyObjectList.Length; i++)
                bodyObjectList[i].SetActive(false);
        }

        if (upperlimbTarget.activeSelf == false)
        {
            for (int i = 0; i < headObjectList.Length; i++)
                UpperLimbList[i].SetActive(false);
        }

        if (legTraget.activeSelf == false)
        {
            legList.SetActive(false);
        }
    }
}
