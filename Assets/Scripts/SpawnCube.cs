using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    [SerializeField]
    private GameObject myCubePrefab;
    
    private void Awake()
    {
        Instantiate(myCubePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
