using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletCollisionScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor" || other.gameObject.tag == "Player")
        {


            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor" || other.gameObject.tag == "Player")
        {


            Destroy(this.gameObject);
        }
    }
}
