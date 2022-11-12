using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin_platter : MonoBehaviour
{
    public GameObject platter;

    // Update is called once per frame
    void Update()
    {
        platter.transform.Rotate(new Vector3(0, 1));
    }
}
