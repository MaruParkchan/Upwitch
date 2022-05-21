using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOn : MonoBehaviour
{
    [SerializeField] GameObject[] objectOn;

    private void Awake()
    {
        ObjectOnMethod();
    }

    public void ObjectOnMethod()
    {
        for (int i = 0; i < objectOn.Length; i++)
            objectOn[i].SetActive(true);
    }
}
