using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 movePos;

    public float yPositionLimit = 7f;

    float verticalAxis;

    private void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        if (verticalAxis != 0)
        {
            movePos = transform.position;
            movePos.y += speed * Time.deltaTime * verticalAxis;
            Debug.Log(movePos.y);
            movePos.y = Mathf.Clamp(movePos.y, 7, yPositionLimit);
            Debug.Log(movePos.y + " " + yPositionLimit);
            transform.position = movePos;
        }
    }
}
