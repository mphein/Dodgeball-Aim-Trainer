using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAround : MonoBehaviour
{
    // Start is called before the first frame update
    // Learned from https://www.youtube.com/watch?v=W70n_bXp7Dc&ab_channel=Unity3DSchool
    
    float rotationX = 0f;
    float rotationY = 0f;

    public float sensitivity = 15f;
    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
