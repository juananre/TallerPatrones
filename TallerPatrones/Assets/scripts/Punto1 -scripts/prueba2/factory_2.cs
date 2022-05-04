using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory_2 <obj> : MonoBehaviour where obj : MonoBehaviour
{
    private static GenericFactory_2<obj> instance;

    [SerializeField]
    private obj esfera;
    [SerializeField]
    private obj cube;
    [SerializeField]
    private obj cilindro;

    public static GenericFactory_2<obj> Instance { get => instance; }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }
    public obj InstaEsfera()
    {
        obj cloneOBJ=Instantiate<obj>(esfera);
        return cloneOBJ;
    }
    public obj InstaCube()
    {
        obj cloneOBJ = Instantiate<obj>(cube);
        return cloneOBJ;
    }
    public obj InstaCilondro()
    {
        obj cloneOBJ = Instantiate<obj>(cilindro);
        return cloneOBJ;
    }
}
