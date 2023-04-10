using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject ShowThis;
    public Text ShowThisText;
    public int orderNumber;
    public int currentOrderNumber;
    public Text yourNumberText;
    public Text currentNumberText;
    public GameObject playerPrefab;
    public float minX = -8.5f;
    public float maxX = 8.5f;
    public float minZ = -8.5f;
    public float maxZ = 8.5f;

    // Update is called once per frame
    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 1.5f, Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        orderNumber = Random.Range(7, 13);
        currentOrderNumber = orderNumber - 2;
        StartCoroutine("DecreaseNumber");
    }

    IEnumerator DecreaseNumber()
    {
        yield return new WaitForSecondsRealtime(25f);
        currentOrderNumber += 1;
        yield return new WaitForSecondsRealtime(25f);
        currentOrderNumber += 1;
        ShowPopUp();

    }

    private void Update()
    {
        currentNumberText.text = "Current Order: " + currentOrderNumber.ToString();
        yourNumberText.text = "Your Order: " + orderNumber.ToString();
    }

    private void ShowPopUp()
    {
        ShowThis.SetActive(true);
        ShowThisText.text = "Your order is ready! You got " + ScoreManager.Instance.PointsShop + " points! Check out the points shop to get some sweet rewards!";
    }


}
