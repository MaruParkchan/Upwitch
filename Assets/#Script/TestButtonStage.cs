using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButtonStage : MonoBehaviour
{
    [SerializeField] GameObject buttonA;
    [SerializeField] GameObject buttonB;
    private void Awake()
    {
        buttonA.SetActive(true);
        buttonB.SetActive(false);
    }
}
