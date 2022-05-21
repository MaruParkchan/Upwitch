using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneSoundEffect : MonoBehaviour
{
    public GameObject fadeObject;
    private MeshRenderer render;
    private float fadeTime = 2.0f;
    private bool IsOn = false;

    private void Awake()
    {
        render = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(render.enabled == true && IsOn == false)
        {
            IsOn = true;
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeOut()
    {
        fadeObject.SetActive(true);
        yield return new WaitForSeconds(fadeTime);
        fadeObject.SetActive(false);
    }
}
