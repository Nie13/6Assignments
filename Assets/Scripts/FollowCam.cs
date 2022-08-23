using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position ;
        if (Input.GetMouseButton(1))
        {
            Cursor.lockState = CursorLockMode.Locked;
            float y = speed * Input.GetAxis("Mouse X");

            transform.Rotate(0, y, 0);
        }
        else Cursor.lockState = CursorLockMode.None;

    }
}
