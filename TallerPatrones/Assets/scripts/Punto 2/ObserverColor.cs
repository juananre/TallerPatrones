using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverColor : MonoBehaviour, IObserver
{
    int count = 1;
    [SerializeField] Renderer cube;

    public void OnButtonClicked(ClickManager color)
    {
        if (count == 5) count = 1;
        switch (count)
        {
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.black;
                count += 1;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.cyan;
                count += 1;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.red;
                count += 1;
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                count += 1;
                break;
        }
    }
}
