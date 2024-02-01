using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody bulletRigid;

    void Start()
    {
        bulletRigid = GetComponent<Rigidbody>();
        bulletRigid.velocity = transform.forward* speed;
        //Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            
            if(playerController != null)
            {
                playerController.Die();
            }
        }
        else if(other.CompareTag("wall"))
        {
            Destroy(this.gameObject);
        }
    }

}
