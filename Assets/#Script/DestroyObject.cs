using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float timer;

    private void Awake()
    {
        Destroy(gameObject, timer);
    }
}
