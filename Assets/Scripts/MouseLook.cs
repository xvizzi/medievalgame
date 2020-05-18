using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform Target, Player, MinZoom, MaxZoom;
    public float mouseSensitivty;

    float mouseX, mouseY;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        mouseX += Input.GetAxis("Mouse X") * mouseSensitivty * Time.deltaTime;
        mouseY -= Input.GetAxis("Mouse Y") * mouseSensitivty * Time.deltaTime;

        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        Player.rotation = Quaternion.Euler(0,mouseX,0);

        ZoomCamera();
    }

    void ZoomCamera(){
        float ScrollWheelChange = Input.GetAxis("Mouse ScrollWheel");
        if (ScrollWheelChange != 0){   
            float R = ScrollWheelChange;
            float PosX = transform.eulerAngles.x + 90;
            float PosY = -1 * (transform.eulerAngles.y - 90);
            PosX = PosX / 180 * Mathf.PI;
            float X = R * Mathf.Sin(PosX) * Mathf.Cos(PosY);
            float Z = R * Mathf.Sin(PosX) * Mathf.Sin(PosY);
            float Y = R * Mathf.Cos(PosX);
            float CamX = transform.position.x;
            float CamY = transform.position.y;
            float CamZ = transform.position.z;
            transform.position = new Vector3(CamX + X, CamY + Y, CamZ + Z);
        }
    }

}
