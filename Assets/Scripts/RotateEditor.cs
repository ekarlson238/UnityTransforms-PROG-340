using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEditor : MonoBehaviour
{
    [SerializeField]
    private float buttonValue = 100;

    private GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        if (myCube == null)
            myCube = GameObject.FindWithTag("Cube");
    }

    public void RotateRight()
    {
        myCube.transform.Rotate(new Vector3(0, 1, 0), -buttonValue);
    }

    public void RotateLeft()
    {
        myCube.transform.Rotate(new Vector3(0, 1, 0), buttonValue);
    }
}
