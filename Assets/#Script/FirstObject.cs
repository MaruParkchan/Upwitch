using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstObject : MonoBehaviour
{
    [SerializeField] private int value;
    bool isOn = false;
    MeshRenderer render;

    private void Awake()
    {
        render = GetComponent<MeshRenderer>();    
    }

    private void Update()
    {
        if (render.isVisible && !isOn)
        {
            isOn = true;
            DataController.listCount = value;
        }
    }
}
