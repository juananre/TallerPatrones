using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private GameObject cilindro;
    [SerializeField]
    private GameObject esfera;



    public GameObject crearCubo()
    {
        GameObject intance = Instantiate(cube);

        return intance;
    }
    public GameObject crearcilindro()
    {
        GameObject intance = Instantiate(cilindro);


        return intance;
    }
    public GameObject crearesfera()
    {
        GameObject intance = Instantiate(esfera);

        return intance;
    }

}
