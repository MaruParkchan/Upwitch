using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TimerChange : SceneChange
{
    [SerializeField] private float timer;

    private void Awake()
    {
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(timer);
        SceneChangeMethod();
    }
}
