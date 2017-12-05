using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;


public class CoffeeSpeedUp : MonoBehaviour {

    public AnimationCurve myCurve;
    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Kari")
        {
            Destroy(gameObject);
            print("Apples");
            coll.gameObject.GetComponent<PlatformerCharacter2D>().m_MaxSpeed += 2;
        }

        if (coll.gameObject.name == "BadGuy")
        {
            coll.gameObject.GetComponent<BadGuy>().movespeed += 3;
            Destroy(gameObject);
            
        }


    }

}

