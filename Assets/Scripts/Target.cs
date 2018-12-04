using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health;
    public float rotationspeed;
    private void Update()
    {
        transform.Rotate(rotationspeed * Time.deltaTime, rotationspeed * Time.deltaTime, rotationspeed * Time.deltaTime);
    }

    public void HitDamage(float damage)
    {
        health -= damage;
        if(health <= 0f)
        {
            destroy_target();
        }
    }

    void destroy_target()
    {
        Destroy(gameObject);
    }
}
