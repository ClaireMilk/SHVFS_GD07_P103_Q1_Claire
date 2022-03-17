using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    private float Timer;
    public float Duration;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < Duration)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            Debug.Log("second");
        }
    }
}
