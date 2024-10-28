using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Threading;
using System;

public class ChangeLight : MonoBehaviour
{
    public GameObject light;
    public GameObject nextScene;
    float lastTapTime = 0;
    float doubleTapTreshold = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began) {
                if(Time.time - lastTapTime <= doubleTapTreshold)
                {
                    lastTapTime = 0;
                    nextScene.SetActive(true);
                }
                else
                {
                    lastTapTime = Time.time;
                }
            }
        }
        if (Input.touchCount > 0)
        {
            light.SetActive(true);
        }
        if (Input.touchCount <= 0)
        {
            light.SetActive(false);
        }
    }
}
