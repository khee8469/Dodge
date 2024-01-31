using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigid;
    [SerializeField] float speed;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        speed = 8;
    }

    
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    rigid.AddForce(Vector3.forward * speed);
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    rigid.AddForce(Vector3.back * speed);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    rigid.AddForce(Vector3.left * speed);
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    rigid.AddForce(Vector3.right * speed);
        //}
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        rigid.velocity = newVelocity;






    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
