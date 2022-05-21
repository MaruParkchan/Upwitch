using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingManager : MonoBehaviour
{
    [SerializeField] GameObject clone;
    TrackObject trackObject;

    private void Awake()
    {
        trackObject = GetComponent<TrackObject>();    
    }

    private void Update()
    {
        if (trackObject.IsTracked)
        {
            clone.SetActive(true);
        }
        else if (trackObject.IsTracked == false)
        {
            clone.SetActive(false);
        }
    }
}
