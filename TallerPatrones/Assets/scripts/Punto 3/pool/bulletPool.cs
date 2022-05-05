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
        if (instance==null)
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
        Addbalapool(poolsize);
    }
    private void Addbalapool(int amount)
    {
        for (int i = 0; i < poolsize; i++)
        {
            GameObject bala = Instantiate(bala1,new Vector3(-10,-10,-10),Quaternion.identity);
            bala.SetActive(false);
            bala1list.Add(bala);
            //bala.transform.parent = transform;
        }
    }
    public GameObject Requestbala(string tagdeBala)
    {
        for (int i = 0; i < bala1list.Count; i++)
        {
            if (!bala1list[i].activeSelf)
            {
                
                bala1list[i].SetActive(true);
                bala1list[i].tag = tagdeBala;
                return bala1list[i];
            }
        }
        return null;
    }
    public void reciclar(GameObject bala)
    {
        bala.SetActive(false);

    }
}
