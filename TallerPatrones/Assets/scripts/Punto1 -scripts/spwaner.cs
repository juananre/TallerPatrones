using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaner : MonoBehaviour
{
    [SerializeField]
    private Factory factory;

    private GameObject esfera;
    private GameObject cubo;
    private GameObject cilindor;


    private void newEsfera()
    {
        esfera = factory.crearesfera();
        esfera.transform.position = transform.position;

    }
    private void newcubo()
    {
        cubo = factory.crearCubo();
       cubo.transform.position = transform.position;
    }
    private void newcilindro()
    {
        cilindor = factory.crearcilindro();
        cilindor.transform.position = transform.position;
    }


   private void genererador()
    {
        
    }
   

}
