using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateEditor : MonoBehaviour
{
    [SerializeField]
    private float buttonValue;

    private GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        if (myCube == null)
            myCube = GameObject.FindWithTag("Cube");
    }

    public void TranslateForward()
    {
        myCube.transform.Translate(Vector3.forward * buttonValue);
    }

    public void TranslateBack()
    {
        myCube.transform.Translate(Vector3.back * buttonValue);
    }
}
