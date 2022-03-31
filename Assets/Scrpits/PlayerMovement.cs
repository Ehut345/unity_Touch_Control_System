using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMoveSpeed;

    void Start()
    {

    }

    void Update()
    {
        MovemnetOfTouch();
    }
    void MovemnetOfTouch()
    {
        /*if (Input.GetMouseButton(0))
        {
            Vector3 refMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (refMousePos.x > 1)
            {
                transform.Translate(playerMoveSpeed * Time.deltaTime, 0, 0);
            }
            else if (refMousePos.x < -1)
            {
                transform.Translate(-playerMoveSpeed * Time.deltaTime, 0, 0);
            }
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(1);
            Vector3 refTouchPos = Camera.main.ScreenToWorldPoint(touch.position);
            refTouchPos.z = 0f;
            transform.position = refTouchPos;
        }*/
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchRefPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchRefPos, Color.red);
        }
    }
}
