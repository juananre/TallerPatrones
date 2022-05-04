using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factory_obj : GenericFactory_2 <Objetec_Base>
{
    public void creacion_Esfera()
    {
        InstaEsfera();
    }

    public void creacion_cube()
    {
        InstaCube();
    }
    public void creacion_cilindro()
    {
        InstaCilondro();
    }

}
