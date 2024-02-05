using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject ballObject;
    public float mouseSensitivity = 7.0f;
    public float power = 25f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void FixedUpdate() 
    {
        float mouseVert = Input.GetAxis("Mouse Y");
        Vector3 rotation = new Vector3(-mouseVert, 0f, 0f);
        transform.Rotate(rotation * mouseSensitivity, Space.Self);
    }

    void Shoot()
    {   
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 20.0f, 1)) {
            Debug.Log(hit.collider.gameObject.name);
        }

        Debug.DrawRay(transform.position, transform.forward, Color.green, 1.0f, true);
        GameObject newBall = Instantiate(ballObject, transform.position + new Vector3(0, .1f, .1f), transform.rotation);
        newBall.GetComponent<Rigidbody>().AddRelativeForce(0, 0, power);
    }
}
