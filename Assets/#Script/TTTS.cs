using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTS : MonoBehaviour
{
    [SerializeField] private int value;

    [SerializeField] GameObject[] clone;

    private void Update()
    {
        if (value == clone.Length)
            value = 0;

        if (Input.GetKeyDown(KeyCode.Space))
            value++;


        Clone();
    }

    private void Clone()
    {
        for(int i = 0; i < clone.Length; i++)
        {
            if (i == value)
                clone[i].SetActive(true);

            else if (i != value)
                clone[i].SetActive(false);
        }
    }
}
