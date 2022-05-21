using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexValuePhone : MonoBehaviour // 핸드폰 누를시 -> 의족 할때 대화창없기 떄문에 이 스크립트 작
{
    public TargetObjectOn obj;

    private bool onClick = false;

    public void IndexValue(int value)
    {
        if (onClick)
            return;

        onClick = true;
        obj.IndexValue(value);
    }
}
