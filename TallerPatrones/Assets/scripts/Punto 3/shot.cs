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
                            GameObject newbullet;
                            newbullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                            newbullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);

                            shotrateTime = Time.time + shotrate;
                            Destroy(newbullet, 1);

                        }
                        break;

                    case 2:
                        if (Time.time > shotrateTime)
                        {
                            GameObject newbullet;
                            newbullet = Instantiate(bullet2, spawnPoint.position, spawnPoint.rotation);
                            newbullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);

                            shotrateTime = Time.time + shotrate;


                            Destroy(newbullet, 1);

                        }
                        break;

                    case 3:
                        if (Time.time > shotrateTime)
                        {
                            GameObject newbullet;
                            newbullet = Instantiate(bullet3, spawnPoint.position, spawnPoint.rotation);
                            newbullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotforce);

                            shotrateTime = Time.time + shotrate;
                            Destroy(newbullet, 1);

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
