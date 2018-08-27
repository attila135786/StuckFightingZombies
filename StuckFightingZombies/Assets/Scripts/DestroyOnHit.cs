using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour
{

    public string collideTag = "Bullet";

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag.Equals(collideTag))
        {
            Destroy(gameObject);
            Destroy(collider.gameObject);
            Debug.Log("a Bullet collided with Zombie");
        }
    }
}
