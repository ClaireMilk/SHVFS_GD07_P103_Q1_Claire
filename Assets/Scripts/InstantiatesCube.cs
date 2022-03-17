using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatesCube : MonoBehaviour
{
    public int CubeIns;
    public float Timer;
    public GameObject Cube;
    GameObject CubeClone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0f)
            CubeClone = Instantiate(Cube, (new Vector3()), transform.rotation) as GameObject;
        Timer = 1f;
    }
}
