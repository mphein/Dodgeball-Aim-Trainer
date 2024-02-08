using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public int maxHealth;
    private int health;
    void Start()
    {
        this.health = Random.Range(1, maxHealth);
    }

    // Update is called once per frame
    public void Hit()
    {
        this.health -= 1;
    }

    private void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            this.Hit();
            if (this.health <= 0)
            {
                Destroy(this.gameObject);
            }
            other.gameObject.SetActive(false);
        }
    }
}
