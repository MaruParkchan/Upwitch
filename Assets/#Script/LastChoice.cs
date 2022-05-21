using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastChoice : MonoBehaviour
{

    [SerializeField] LastChoiceButtonActive buttonValue;
    [SerializeField] private string gameEndingName;
    [SerializeField] private string gameOverName;
    [SerializeField] private int successValue;
    [SerializeField] GameObject success;
    [SerializeField] GameObject fail;
    private bool isSelect = false;

    public void YesOrNo()
    {
        if (isSelect)
            return;

        isSelect = true;
        StartCoroutine(SelectChoice());


    }

    public void LastChoicceButton()
    {
        if (buttonValue.Value == successValue)
            SceneManager.LoadScene(gameEndingName);
        else if (buttonValue.Value != successValue) // 범인 선택이 이사람이 아닐시 게임오버씬 전환하는 else  
            SceneManager.LoadScene(gameOverName);
    }

    IEnumerator SelectChoice()
    {
        if (buttonValue.Value == successValue)
            success.SetActive(true);
        else if (buttonValue.Value != successValue) // 범인 선택이 이사람이 아닐시 게임오버씬 전환하는 else  
            fail.SetActive(true);

        yield return new WaitForSeconds(2.0f);
        LastChoicceButton();

    }
}
