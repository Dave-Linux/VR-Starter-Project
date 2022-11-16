using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f; //The distance needed to register a push
    [SerializeField] private float deadzone = 0.015f; //Distance where no push is registered
    [SerializeField] private TextMeshPro debugText;

    private bool isPressed;
    private Vector3 startPosition;
    private ConfigurableJoint joint;

    public UnityEvent onPressed, onReleased;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition;
        joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPressed && GetValue() + threshold >= 1 )
            Pressed();
        else if (isPressed && GetValue() - threshold <= 0)
            Released();
    }

    //Returns the  
    private float GetValue()
    {
        var value = Vector3.Distance(startPosition, transform.localPosition) / joint.linearLimit.limit;
        float returnValue;

        if (Mathf.Abs(value) < deadzone)
            value = 0;

        returnValue = Mathf.Clamp(value, -1f, 1f);
        debugText.text = "Y = " + returnValue;

        return returnValue;
    }

    //Button has been pressed
    private void Pressed()
    {
        isPressed = true;
        onPressed.Invoke(); //Triggers any event added by developer in Unity editor
        Debug.Log("Button Pressed!");
    }

    //Button has been released
    private void Released()
    {
        isPressed = false;
        onReleased.Invoke(); //Triggers any event added by developer in Unity editor
        Debug.Log("Button Released!");
    }
}
