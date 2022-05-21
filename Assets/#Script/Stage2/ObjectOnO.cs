using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOnO : MonoBehaviour
{
    public GameObject targetOn;
    private bool isOn = false;
    public void OnObjectTarget()
    {
        if (isOn)
            return;

        isOn = true;
        targetOn.SetActive(true);
    }
}
