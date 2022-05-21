using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsOff : MonoBehaviour
{
    [SerializeField] private GameObject[] offObjects;
    [SerializeField] private GameObject[] onObjects;

    public void ObjectActiveOn()
    {
        for (int i = 0; i < onObjects.Length; i++)
            onObjects[i].SetActive(true);
    }

    public void ObjectActiveOff()
    {
        for (int i = 0; i < onObjects.Length; i++)
        {
            offObjects[i].transform.gameObject.SetActive(false);
        }
    }

    
}
