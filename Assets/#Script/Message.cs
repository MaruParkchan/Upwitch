using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Message : MonoBehaviour
{
    [SerializeField] private GameObject textObject;
    [SerializeField] private Text messageText;
    [SerializeField] private float timer = 0;

    private void Awake()
    {
        textObject.SetActive(false);
        messageText.text = "단서를 찾았습니다.";
    }

    public void MessageOn()
    {
        StartCoroutine(IMessage());
    }

    IEnumerator IMessage()
    {
        textObject.SetActive(true);
        yield return new WaitForSeconds(timer);
        textObject.SetActive(false);
    }
}
