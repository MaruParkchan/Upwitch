using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsConditionObject : MonoBehaviour
{
    public TrackObject trackObject;
    public GameObject conditionObject;
    public GameObject fadeObject;
    public AudioSource audio;
    public float fadeTime = 2.0f;
    private bool isClick = false;
    private bool isSound = false;
    public GameObject targetOn;
    public GameObject clueButtonOn;

    public bool isFirst = false;

    private void Update()
    {
        if (isFirst == true)
        {
            CorpseClick2();
        }
        else if(isFirst == false)
            CorpseClick();
    }

    public void CorpseClick()
    {
        if (isClick)
            return;

            if (trackObject.IsTracked && conditionObject.activeSelf)
            {
                isClick = true;
                targetOn.SetActive(true);
            }
            else
                targetOn.SetActive(false);

        if (trackObject.IsTracked && conditionObject.activeSelf && isSound == false)
        {
            isSound = true;
            clueButtonOn.SetActive(true);
            audio.Play();
            StartCoroutine(FadeOut());
            
        }
    }
    public void CorpseClick2()
    {
        if (isClick)
            return;

        if (trackObject.IsTracked && conditionObject.activeSelf)
        {
            targetOn.SetActive(true);
        }
        else
            targetOn.SetActive(false);

        if (trackObject.IsTracked && conditionObject.activeSelf && isSound == false)
        {
            isSound = true;
            clueButtonOn.SetActive(true);
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
