using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_movement : MonoBehaviour {

    public new Rigidbody rigidbody;
    public GameObject ship;
    public GameObject bighitEffect;
    public GameObject bighitEffectBlue;
    public float ship_speed;
    public float axis_x;
    public float axis_y;

    public Text score;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, ship_speed * Time.deltaTime,ForceMode.VelocityChange);
        shipeMove();
        
    }

    void shipeMove()
    {
        if(Input.GetKey("a")) { 
            Debug.Log("Left");
            rigidbody.AddForce(-axis_x * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("d"))
        {
            Debug.Log("Right");
            rigidbody.AddForce(axis_x * Time.deltaTime, 0, 0);
        }
        //else if (Input.GetKey("w"))
        //{
        //    rigidbody.AddForce(0, axis_y * Time.deltaTime, 0);
        //}
        //else if (Input.GetKey("s"))
        //{
        //    rigidbody.AddForce(0, -axis_y * Time.deltaTime, 0);
        //}
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacles")
        {
            Debug.Log("Hit on" + collision.collider.name);

            //FindObjectOfType<ScorePass>().FinalScore = score.ToString();

            FindObjectOfType<Score>().enabled = false;
            FindObjectOfType<BoundryMove>().enabled = false;
            FindObjectOfType<CameraObject>().enabled = false;
            Destroy(Instantiate(bighitEffect, transform.position, Quaternion.LookRotation(transform.forward)), 2f);
           // Destroy(Instantiate(bighitEffectBlue, transform.position, Quaternion.LookRotation(transform.forward)), 2f);
            Invoke("explorePlasma", 0.5f);
        }
    }

    void explorePlasma()
    {
        Destroy(ship);
        FindObjectOfType<GameManager>().SceneType("GameOver");
    }
}
