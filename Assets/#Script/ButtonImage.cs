using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImage : MonoBehaviour
{
    [SerializeField] private int value;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject isActiveImage;


    void Update()
    {
        if (DataController.listCount == value)
        {
            isActiveImage.SetActive(true);
            target.SetActive(false);
        }
    }
}
