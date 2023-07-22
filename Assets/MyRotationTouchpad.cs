using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MyRotationTouchpad : MonoBehaviour
{
 
    public Transform RotatableH;
    public Transform RotatableV;
    public float RotationSpeed = .1f;
    public bool InvertedV = true;
    public bool LimitedV = true;
 
    bool ismouseheld;
    Vector2 currentMousePosition;
    Vector2 mouseDeltaPosition;
    Vector2 lastMousePosition;
    bool istouchpadactive;
 
    private void Start()
    {
        ResetMousePosition();
    }
 
    public void ResetMousePosition()
    {
        currentMousePosition = Input.mousePosition;
        lastMousePosition = currentMousePosition;
        mouseDeltaPosition = currentMousePosition - lastMousePosition;
    }
 
    void FixedUpdate()
    {
        if (istouchpadactive)
        {
 
            currentMousePosition = Input.mousePosition;
            mouseDeltaPosition = currentMousePosition - lastMousePosition;
 
            if (RotatableH != null)
                RotatableH.transform.Rotate(0f, mouseDeltaPosition.x * RotationSpeed, 0f);
            if (RotatableV != null)
            {
 
                if (LimitedV)
                {
                    if (RotatableV.transform.rotation.x <= .45 && RotatableV.transform.rotation.x >= -.45)
                    {
                        if (InvertedV)
                            RotatableV.transform.Rotate(Mathf.Clamp(mouseDeltaPosition.y * (RotationSpeed * -1), -3, 3), 0f, 0f);
                        else
                            RotatableV.transform.Rotate(Mathf.Clamp(mouseDeltaPosition.y * RotationSpeed, -3, 3), 0f, 0f);
                    }
                }
                else
                {
                    if (InvertedV)
                        RotatableV.transform.Rotate(Mathf.Clamp(mouseDeltaPosition.y * (RotationSpeed * -1), -3, 3), 0f, 0f);
                    else
                        RotatableV.transform.Rotate(Mathf.Clamp(mouseDeltaPosition.y * RotationSpeed, -3, 3), 0f, 0f);
                }
 
            }
 
            lastMousePosition = currentMousePosition;
 
 
        }
 
        if (LimitedV)
        {
            if (RotatableV.transform.rotation.x > .45)
                RotatableV.transform.Rotate(-1f, 0f, 0f);
            if (RotatableV.transform.rotation.x < -.45)
                RotatableV.transform.Rotate(1f, 0f, 0f);
        }
 
    }
 
    public void ActivateTouchpad()
    {
        ResetMousePosition();
        istouchpadactive = true;
    }
 
    public void DeactivateTouchpad()
    {
        istouchpadactive = false;
    }
}