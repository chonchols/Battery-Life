using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [Header(" Settings ")]
    [SerializeField]
    private Vector2 slideCoefficient;

    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 15;
    [SerializeField] private float moveCoefficient = 10;
    [SerializeField] private float platformWidth = 10;

    [Header(" Events ")]
    public UnityEvent onMouseDown;
    public UnityEvent onMouseDrag;
    public UnityEvent onMouseUp;

    //public int minusValue;
    public Rigidbody rb;
    public float force = 0.5f;

    [SerializeField]
    private Vector3 slidePressedPos;
    [SerializeField]
    private Vector3 slideReleasedPos;
    private float moveMagnitudeX;
    private float moveMagnitudeY;
    private bool pressed = false;
    private Vector3 clickedPosition;
    public bool isActive = false;
    public GameObject player;

 
    [SerializeField]
    private float startPosition;

    public void Awake()
    {
        instance = this;
    }



    public void ManageSlideControl()
    {

        MoveForward();
        // On click down, save the 2 positions
        if (Input.GetMouseButtonDown(0) && !pressed)
        {
            pressed = true;
           // slidePressedPos = GetCorrectedMousePosition();
          //  slideReleasedPos = GetCorrectedMousePosition();
            StoreClickedPosition();
           // onMouseDown?.Invoke();
        }
        else if (Input.GetMouseButton(0) && pressed)
        {
            slideReleasedPos = GetCorrectedMousePosition();
             moveMagnitudeX = slideReleasedPos.x - slidePressedPos.x;
           moveMagnitudeX *= slideCoefficient.x / (float)Screen.width;
            moveMagnitudeY = slideReleasedPos.y - slidePressedPos.y;
            moveMagnitudeY *= slideCoefficient.y / (float)Screen.height;

            GetSlideValue(new Vector2(moveMagnitudeX, moveMagnitudeY));
          
            onMouseDrag?.Invoke();
           
        }
        else if (Input.GetMouseButtonUp(0) && pressed)
        {
         //   moveMagnitudeX = 0;
         //   moveMagnitudeY = 0;
            pressed = false;
            onMouseUp?.Invoke();
       
         
        }
        floatingState();
    }
    Vector3 GetCorrectedMousePosition()
    {
        Vector3 actualMousePos = new Vector3(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2, Input.mousePosition.z);
        return actualMousePos;
    }


    public void GetSlideValue(Vector2 slideInput)
    {
        slideInput.x *= moveCoefficient;
        float targetX = clickedPosition.x + slideInput.x;
        float maxX = platformWidth / 2 - GetPlayeRadius();
           targetX = Mathf.Clamp(targetX, -maxX, maxX);
          transform.position = transform.position.With(x: Mathf.Lerp(transform.position.x, targetX, 0.3f));
        //transform.position = transform.position.With(x: transform.position.x* targetX);
      
    }

    [Range(0f, 3.5f)]
    [SerializeField] private float radiusFactor;
    public float GetPlayeRadius()
    {
        return radiusFactor;
    }


    public void MoveForward()
    {
        
        player.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

    }

    public void floatingState()
    {
        rb.AddForce(Vector3.up * force);
    }

    public void StoreClickedPosition()
    {
        clickedPosition = player.transform.position;
    }
}
public static class Vectorextension
{
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null)
    {
        return new Vector3(x ?? original.x, y ?? original.y, z ?? original.z);
    }
}
