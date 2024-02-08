using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ThrowBall : MonoBehaviour
{
    public GameObject ballObject;
    public float power = 25f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot()
    {   
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 20.0f, 1)) {
            Debug.Log(hit.collider.gameObject.name);
        }

        Debug.DrawRay(transform.position, transform.forward, Color.green, 1.0f, true);
        
        GameObject ball = BallPool.sharedInstance.GetPooledObject();
        
        ball.transform.position = transform.position;
        ball.transform.rotation = transform.rotation;
        ball.SetActive(true);


        if (ball != null) {
            Rigidbody rb = ball.GetComponent<Rigidbody>();
            rb.angularVelocity = Vector3.zero; rb.velocity = Vector3.zero;
            rb.AddRelativeForce(new Vector3(0,0,power));
        }
    }
}
