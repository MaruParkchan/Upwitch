using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSound : MonoBehaviour
{
    public TrackObject trackObject;
    public GameObject conditionObject;
    public GameObject fadeObject;
    private AudioSource audio;
    public float fadeTime = 2.0f;
    private bool isClick = false;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        CorpseClick();
    }

    public void CorpseClick()
    {
        if (trackObject.IsTracked && conditionObject.activeSelf && isClick == false)
        {
            isClick = true;
            audio.Play();
            StartCoroutine(FadeOut());
        }
    }

    public void Click()
    {
        isClick = true;
    }

    IEnumerator FadeOut()
    {
        fadeObject.SetActive(true);
        yield return new WaitForSeconds(fadeTime);
        fadeObject.SetActive(false);
    }
}
