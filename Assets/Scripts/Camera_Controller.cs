using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraController : MonoBehaviour
{
    [SerializeField] float mousesensitivity = 500f;
    Transform playerbody;
    float xRoation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerbody = transform.parent;
    }
    void Update()
    {
        CameraRotation();
    }

    void CameraRotation()
    {
        float MouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

        xRoation -= MouseY;
        xRoation = Mathf.Clamp(xRoation, -90f, 80f);
        transform.localRotation = Quaternion.Euler(xRoation, 0f, 0f);
        playerbody.Rotate(Vector3.up *  MouseX);

    }
}
