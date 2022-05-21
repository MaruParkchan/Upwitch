using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetObjectOn : MonoBehaviour
{
    public GameObject[] targets;

    public int index = 0;

    private void Awake()
    {
        for (int i = 0; i < targets.Length; i++)
            targets[i].SetActive(false);

    }
    private void Update()
    {

    }

    public void IndexValue(int value)
    {
        index = value;

        for (int i = 0; i < index; i++)
        {
            targets[i].SetActive(true);
        }
    }
}
