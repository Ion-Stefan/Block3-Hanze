using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPointsShop : MonoBehaviour
{
    public GameObject hideThis1;
    public GameObject hideThis2;
    public GameObject hideThis3;

    public GameObject showThis1;
    private bool isShopOpen = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OpenPointsShop()
    {
        isShopOpen = true;
        hideThis1.SetActive(false);
        hideThis2.SetActive(false);
        hideThis3.SetActive(false);
        showThis1.SetActive(true);
    }

    private void ClosePointsShop()
    {
        isShopOpen = false;
        hideThis1.SetActive(true);
        hideThis2.SetActive(true);
        hideThis3.SetActive(true);
        showThis1.SetActive(false);
    }

    public void InterractiblePointsShopButton()
    {
        if (isShopOpen == false)
        {
            OpenPointsShop();
        }
        else if (isShopOpen == true)
        {
            ClosePointsShop();
        }
    }
}
