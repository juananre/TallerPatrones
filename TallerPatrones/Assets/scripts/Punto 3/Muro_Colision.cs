using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro_Colision : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider box;

    [SerializeField] int seg;

    [SerializeField] GameObject arma;

    shot perso;

    float tiemporstante;
    bool inico = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
        arma = FindObjectOfType<shot>().gameObject;
        perso = arma.GetComponent<shot>();


        tiemporstante = seg;
    }

    private void Update()
    {
        if (inico == true)
        {
            tiemporstante -= Time.deltaTime;

            if (tiemporstante <= 0)
            {
                inico = false;
                tiemporstante = seg;
                box.enabled = true;
                perso.canShoot = true;
            }
        }
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        // caso 1
        if (collision.gameObject.tag == "bala1")
        {
            print("holi");

        }
        //caso 2
        else if(collision.gameObject.tag == "bala2")
        {
            inico = true;
            box.enabled = false;
            perso.canShoot = false;
        }

    }

}
