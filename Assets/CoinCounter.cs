using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CoinCounter : MonoBehaviour
{
    public int CoinPoints;
    PhotonView view;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            ScoreManager.Instance.AddPoint();
        }
    }
}
