using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook_Clamped : MonoBehaviour
{
    public float pitchMultiplier;
    public float minAngle;
    public float maxAngle;
    public float yawMultiplier;
    float pitch;
    float yaw;
    public float minYaw;
    public float maxYaw;
    private Quaternion camRotation;

    private void Start()
    {
        camRotation = transform.localRotation;
    }

    void Update()
    {
        pitch += Input.GetAxis("Mouse Y") * -1 * pitchMultiplier; //look up and down
        yaw += Input.GetAxis("Mouse X") * 1 * yawMultiplier; //look left and right

        pitch = Mathf.Clamp(pitch, minAngle, maxAngle);
        yaw = Mathf.Clamp(yaw, minYaw, maxYaw);

        transform.localRotation = Quaternion.Euler(pitch, yaw, camRotation.z);





        // pitch += Input.GetAxis("Mouse Y") * 10 * pitchMultiplier * Time.deltaTime;
        // Debug.Log (pitch);
        //transform.Rotate(pitch , 0, 0);

        //Clamp(float value, float min, float max)
        // Mathf.Clamp(eulerpitch, minAngle, maxAngle);


    }
}
