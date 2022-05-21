using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffSystem : MonoBehaviour
{
    public TrackObject trackObject;
    public GameObject conditionObject;

    public GameObject onObject;
    public GameObject offObject;

    public GameObject[] onObjects;
    public GameObject[] offObjects;

    private bool isOn = false;

    private void Awake()
    {
        onObject.SetActive(false);
        offObject.SetActive(true);
    }

    private void Update()
    {
        if (trackObject.IsTracked && conditionObject.activeSelf && isOn == false)
        {
            for (int i = 0; i < onObjects.Length; i++)
            {
                if (onObjects[i] != null)
                    onObjects[i].SetActive(true);
            }

            for (int i = 0; i < offObjects.Length; i++)
            {
                if (offObjects[i] != null)
                    offObjects[i].SetActive(false);
            }
            onObject.SetActive(true);
            offObject.SetActive(false);
            isOn = true;
        }
    }
}
