using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;
    private Rigidbody PlayerRigidBody;
    public GameManager GameManager;

    void Start()
    {
        PlayerRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(moveHorizontal, 0, moveVertical);
        PlayerRigidBody.AddForce(Movement * Speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coins")
        {
            Destroy(collision.gameObject);
            GameManager.AddScore();
        }

        if (collision.gameObject.tag == "Walls")
        {           
            GameManager.YouLose();
        }
    }

}
