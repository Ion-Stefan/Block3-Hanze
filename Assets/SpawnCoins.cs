using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnCoins : MonoBehaviour
{
    public float timeToSpawnCoin;
    private bool canSpawn = true;
    public GameObject coinPrefab;
    public float minXcoin = -8.5f;
    public float maxXcoin = 8.5f;
    public float minZcoin = -8.5f;
    public float maxZcoin = 8.5f;

    private void FixedUpdate()
    {
        if (canSpawn)
        {
            StartCoroutine("spawnCoin");
        }
    }

    IEnumerator spawnCoin()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minXcoin, maxXcoin), 1f, Random.Range(minZcoin, maxZcoin));
        PhotonNetwork.Instantiate(coinPrefab.name, randomPosition, Quaternion.identity);
        canSpawn = false;
        yield return new WaitForSecondsRealtime(timeToSpawnCoin);
        canSpawn = true;
    }
}
