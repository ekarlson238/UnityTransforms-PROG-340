using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEditor : MonoBehaviour
{
    [SerializeField]
    private int buttonValue;

    private GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        if (myCube == null)
            myCube = GameObject.FindWithTag("Cube");
    }

    
}
