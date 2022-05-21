using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActive : MonoBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private int value = 0;

    public void IsObjectActive()
    {
        if (DataController.listCount >= value)
        {
            target.SetActive(true);
        }
    }

}
