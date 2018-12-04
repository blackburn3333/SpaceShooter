using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipGun : MonoBehaviour {
    public float damage;
    public float range;

    public float hitForce;
    public float hitCount;

    public int maxAmmo;
    public int currentAmmo;
    public float reloadTime;

    public Camera gunCamera;
    public ParticleSystem shipGunBullets;

    public GameObject hitEffect;
    public GameObject ExplosionhitEffect;
    public GameObject ExplosionhitEffectBlue;

    
    public Text ammoCounter;
    // Use this for initialization

    void Start () {
         currentAmmo = maxAmmo;
           // laserShoot.clip = laserShoolclip;
    }
	
	// Update is called once per frame
	void Update () {


        ammoCounter.text = currentAmmo.ToString();
        if (currentAmmo <= 0)
        {
            StartCoroutine(reloadCannon());
        }
        else {
            if (Input.GetButtonDown("Fire1"))
            {
                currentAmmo--;
                fire();
            }
        }
       

    }

    void fire()
    {
        shipGunBullets.Play();
        RaycastHit gunHit;
        
        if (Physics.Raycast(gunCamera.transform.position,gunCamera.transform.forward,out gunHit,range))
        {
            if(gunHit.transform.tag == "Obstacles")
            {
                Target target = gunHit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.HitDamage(damage);
                }
                if(gunHit.rigidbody != null)
                {
                    gunHit.rigidbody.AddForce(-gunHit.normal * hitForce);
                }
                
                if(hitCount >= 2)
                {
                    
                    hitCount = hitCount - 1;
                    Destroy(Instantiate(hitEffect, gunHit.point, Quaternion.LookRotation(gunHit.normal)), 2f);
                }
                else if(hitCount <= 1)
                {
                    hitCount = 2;
                    Destroy(Instantiate(ExplosionhitEffect, gunHit.point, Quaternion.LookRotation(gunHit.normal)), 2f);
                    //Destroy(Instantiate(ExplosionhitEffectBlue, gunHit.point, Quaternion.LookRotation(gunHit.normal)), 2f);
                }
            }

        }
    }

    IEnumerator reloadCannon()
    {
        ammoCounter.text = "Realoding...";
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
    }
}
