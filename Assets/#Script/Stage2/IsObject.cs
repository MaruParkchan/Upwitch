using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsObject : MonoBehaviour
{
    public GameObject target;

    public void IsActive()
    {
        if (target.activeSelf == true)
            target.SetActive(false);
        else if (target.activeSelf == false)
            target.SetActive(true);
    }
}
