using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro_Colision : MonoBehaviour
{
    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        // caso 1
        if (collision.gameObject.tag == "bala1")
        {
            print("holi");

        }
        //caso 2
        else if((collision.gameObject.tag == "bala2")
        {

        }

    }

}
