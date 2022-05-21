using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFix : MonoBehaviour
{
    // Use this for initialization
 //   [RuntimeInitializeOnLoadMethod]
    private void Awake()
    {
        //        고정 192 x.1080 
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
      //  Screen.SetResolution(900, 1600, true);
        // 비율 예 2:3 
    //    Screen.SetResolution(Screen.width, (Screen.width / 9) * 16,true);
        Screen.orientation = ScreenOrientation.Portrait;
    }
}
