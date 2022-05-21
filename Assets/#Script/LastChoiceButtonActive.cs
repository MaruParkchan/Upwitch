using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastChoiceButtonActive : MonoBehaviour
{
    [SerializeField] Color isActiveOffColor;  
    [SerializeField] Image[] characterImages;
    [SerializeField] GameObject offSelectButton;
    [SerializeField] GameObject selectButton;
    private int value = -1;
    public int Value
    {
        get { return value; }
    }

    private void Update()
    {
        for(int i = 0; i < characterImages.Length; i++)
        {
            if(i == value)
            {
                characterImages[i].color = Color.white;
            }
            else if( i != value)
            {
                characterImages[i].color = isActiveOffColor;
            }
        }       
    }

    public void CharacterChoice(int num)
    {
        offSelectButton.SetActive(false);
        selectButton.SetActive(true);
        value = num;
    }
}
