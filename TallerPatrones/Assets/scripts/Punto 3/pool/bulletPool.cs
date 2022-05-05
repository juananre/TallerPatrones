using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPool : MonoBehaviour
{
    [SerializeField] private GameObject bala1;
    [SerializeField] private int poolsize = 10;
    [SerializeField] private List<GameObject> bala1list;

    private static bulletPool instance;
    public static bulletPool Instace { get { return instance; } }
    private void Awake()
    {
        if (instance)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        for(int i = 0; i < poolsize; i++) 
        {
            GameObject bala = Instantiate(bala1);
            bala.SetActive(false);
            bala1list.Add(bala);
            bala.transform.parent=transform;
        }
        
    }


}
