using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    private GameObject cilindro;
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
