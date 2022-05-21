using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkEvent : MonoBehaviour
{
    [SerializeField] GameObject[] talkObjects;
    int value = 0;

    public AudioSource sound;

    public void TalkPlus()
    {
        if (value == talkObjects.Length)
            return;

        value++;
        if (sound != null)
            sound.Play();

        for (int i = 0; i < talkObjects.Length; i++)
        {
            if (i == value)
                talkObjects[i].SetActive(true);

            else if (i != value)
                talkObjects[i].SetActive(false);
        }

    }
}
