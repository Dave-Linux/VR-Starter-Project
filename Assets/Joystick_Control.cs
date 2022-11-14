using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.VisualScripting;
using TMPro;

public class Joystick_Control : MonoBehaviour
{
    public Transform JoystickTop;
    public GameObject Player;
    public GameObject ColliderIndicator;
    public GameObject UpIndicator;
    public GameObject DownIndicator;
    public GameObject LeftIndicator;
    public GameObject RightIndicator;
    public TextMeshPro XValue;
    public TextMeshPro ZValue;
    public SphereCollider Controller;
    private float forwardBackwardTilt;
    private float sideToSideTilt;
    private Joystick_Control instance;

    private void Start()
    {
        forwardBackwardTilt = 0;
        sideToSideTilt = 0;
    }
    // Update is called once per frame
    void Update()
    {
        forwardBackwardTilt = JoystickTop.rotation.eulerAngles.x;
        sideToSideTilt = JoystickTop.rotation.eulerAngles.z;

        XValue.text = "X = " + forwardBackwardTilt;
        ZValue.text = "Z = " + sideToSideTilt;

        DownIndicator.GetComponent<Renderer>().material.color = Color.red;
        UpIndicator.GetComponent<Renderer>().material.color = Color.red;
        LeftIndicator.GetComponent<Renderer>().material.color = Color.red;
        RightIndicator.GetComponent<Renderer>().material.color = Color.red;

        //Check backward movement
        if (forwardBackwardTilt <355 && forwardBackwardTilt > 290)
        {
            forwardBackwardTilt = math.abs(forwardBackwardTilt - 360);
            Debug.Log("Backward: " + forwardBackwardTilt);
            Player.transform.position = new Vector3((Player.transform.position.x - 1), Player.transform.position.y);
            DownIndicator.GetComponent<Renderer>().material.color = Color.green;
        }
        //Check Forward movement
        else if (forwardBackwardTilt < 74 && forwardBackwardTilt > 5)
        {
            Debug.Log("Forward: " + forwardBackwardTilt);
            Player.transform.position = new Vector3(( Player.transform.position.x + 1), Player.transform.position.y);
            UpIndicator.GetComponent<Renderer>().material.color = Color.green;

        }
        //Check right movement
        if (sideToSideTilt < 355 && sideToSideTilt > 290)
        {
            sideToSideTilt = math.abs(sideToSideTilt - 360);
            Debug.Log("Right: " + sideToSideTilt);
            RightIndicator.GetComponent<Renderer>().material.color = Color.green;

        }
        //Check left movement
        else if (sideToSideTilt < 74 && sideToSideTilt > 5)
        {
            
            Debug.Log("Left: " + sideToSideTilt);
            LeftIndicator.GetComponent<Renderer>().material.color = Color.green;

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Controller") && this.enabled)
        {
            transform.LookAt(other.transform.position, transform.up);
            ColliderIndicator.GetComponent<Renderer>().material.color = Color.green;
        }
        /*
        if (other.CompareTag(""))
        {
            transform.position = defaultPosition.position;
            ColliderIndicator.GetComponent<Renderer>().material.color = Color.red;
        }
        */
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Controller") || this.enabled)
        {
            ColliderIndicator.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}

