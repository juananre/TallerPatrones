using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void CambiarEscena_punto3()
    {
        SceneManager.LoadScene("Punto3");
    }
    public void CambiarEscena_punto2()
    {
        SceneManager.LoadScene("Punto2");
    }
    public void CambiarEscena_punto1()
    {
        SceneManager.LoadScene("Punto1");
    }
    public void CambiarEscena_menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void salir()
    {
        
    }
}
