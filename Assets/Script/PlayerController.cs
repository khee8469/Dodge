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
