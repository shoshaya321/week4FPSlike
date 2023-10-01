using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    public bool hasTouchedGround = false;
    public Rigidbody rb;
    public GameObject Floor;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTouchedGround)
        {
            transform.LookAt(target.transform.position);
            rb.velocity = transform.forward * 0.5f;

        }
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            hasTouchedGround = true;
        }

        if (!FindObjectOfType<Spawner>().gateIsOpen && collision.gameObject.tag == "Floor")
        {
            FindObjectOfType<Spawner>().CreatGate();
        }
    }
}
