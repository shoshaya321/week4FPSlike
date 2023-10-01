using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float speed = 1f;
    public Rigidbody rb;
    public float jumpHeight = 200f;
    public bool isTouchingGround;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);

        if (isTouchingGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight);
            isTouchingGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isTouchingGround = true;
    }
}
