using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    [SerializeField] ParticleSystem particula;
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public Transform spawnPoint;

    public float shotforce;
    public float shotrate;

    public float shotrateTime;

    public int CaseShot =1;

    public bool canShoot=true;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (canShoot) 
            {
                switch (CaseShot)
                {
                    case 1:
                        if (Time.time > shotrateTime)
                        {
                            GameObject bala = bulletPool.Instace.Requestbala("bala1");
                            bala.transform.position = spawnPoint.position;
                            print(spawnPoint.position+" "+bala.transform.position);
                            bala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);
                            print(bala.transform.childCount);
                            bala.transform.GetChild(0).gameObject.SetActive(true);
                            bala.transform.GetChild(1).gameObject.SetActive(false);
                            bala.transform.GetChild(2).gameObject.SetActive(false);
                            shotrateTime = Time.time + shotrate;

                            
                        }
                        break;

                    case 2:
                        if (Time.time > shotrateTime)
                        {
                            GameObject bala = bulletPool.Instace.Requestbala("bala2");
                            bala.transform.position = spawnPoint.position;
                            bala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);

                            bala.transform.GetChild(0).gameObject.SetActive(false);
                            bala.transform.GetChild(1).gameObject.SetActive(true);
                            bala.transform.GetChild(2).gameObject.SetActive(false);
                            shotrateTime = Time.time + shotrate;


                        }
                        break;

                    case 3:
                        if (Time.time > shotrateTime)
                        {
                            GameObject bala = bulletPool.Instace.Requestbala("bala3");
                            bala.transform.position = spawnPoint.position;
                            bala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);

                            bala.transform.GetChild(0).gameObject.SetActive(false);
                            bala.transform.GetChild(1).gameObject.SetActive(false);
                            bala.transform.GetChild(2).gameObject.SetActive(true);
                            shotrateTime = Time.time + shotrate;

                        }
                        break;

                }

            }

            
           

        }
        else if (Input.GetButtonDown("Fire2"))
        {
            CaseShot++;
            if (CaseShot > 3) 
            {
                CaseShot = 1;
            }
        }
        
    }
    public void InstanciateParticle()  
    {
        Instantiate(particula);
    }
}
