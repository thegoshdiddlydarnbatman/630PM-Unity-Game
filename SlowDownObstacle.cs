using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class SlowDownObstacle : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Kari")
        {
            Destroy(gameObject);
            print("Apples");
            //GetComponent<Collider>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            coll.gameObject.GetComponent<PlatformerCharacter2D>().m_MaxSpeed -= 1;
        }
    }
}