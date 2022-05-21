using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsObjectOnOff : MonoBehaviour
{
    public GameObject offObject;
    public GameObject onObject;

    public void OnOffObject()
    {
        offObject.SetActive(false);
        onObject.SetActive(true);
    }
}
