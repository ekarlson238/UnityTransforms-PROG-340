using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleEditor : MonoBehaviour
{
    [SerializeField]
    private float buttonValue = 0.2f;

    private GameObject myCube;

    // Start is called before the first frame update
    void Start()
    {
        if (myCube == null)
            myCube = GameObject.FindWithTag("Cube");
    }

    /// <summary>
    /// increase by buttonValue %
    /// </summary>
    public void ScaleIncrease()
    {
        myCube.transform.localScale = new Vector3(myCube.transform.localScale.x + myCube.transform.localScale.x * buttonValue,
            myCube.transform.localScale.y + myCube.transform.localScale.y * buttonValue,
            myCube.transform.localScale.z + myCube.transform.localScale.z * buttonValue);
    }

    /// <summary>
    /// decrease by buttonValue %
    /// </summary>
    public void ScaleDecrease()
    {
        myCube.transform.localScale = new Vector3(myCube.transform.localScale.x - myCube.transform.localScale.x * buttonValue,
            myCube.transform.localScale.y - myCube.transform.localScale.y * buttonValue,
            myCube.transform.localScale.z - myCube.transform.localScale.z * buttonValue);
    }
}
