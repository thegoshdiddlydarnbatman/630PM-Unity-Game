using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour {

    public int movespeed = 3;
    public Vector3 userDirection = Vector3.right;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(userDirection * movespeed * Time.deltaTime);

    }

    void OnTriggerEnter(Collider Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            //game over stuff
        }
    }

    }
