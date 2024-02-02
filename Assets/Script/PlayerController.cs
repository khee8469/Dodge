using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    Vector3 vector;
    public float speed;
    public float rotateSpeed;

    private void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        vector.z = input.y;
        vector.y = input.x;
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * vector.z * speed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * vector.y * rotateSpeed * Time.deltaTime);
    }

    void Update()
    {
        Move();
        Rotate();
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
