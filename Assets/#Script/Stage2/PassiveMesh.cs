using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveMesh : MonoBehaviour
{
    [SerializeField] TrackObject trackObject;
    [SerializeField] GameObject human;

    public GameObject[] objects;

    public Material[] maters;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if (trackObject.IsTracked == true && human.activeSelf == true)
        {
            for(int i = 0; i < objects.Length; i++)
            {
                objects[i].AddComponent<MeshRenderer>();
                objects[i].GetComponent<MeshRenderer>().material = maters[i];
            }
        }
        else
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Destroy(objects[i].GetComponent<MeshRenderer>());
            }
        }
    }
}
