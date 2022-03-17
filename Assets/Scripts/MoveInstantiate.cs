using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInstantiate : MonoBehaviour
{
    public int CubeIns;
    public float Timer;
    public GameObject Cube;
    GameObject CubeClone;

    private Transform Transform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
            CubeClone = Instantiate(Cube, (transform.position()), transform.rotation) as GameObject;
        Timer = 1f;
    }
}
