using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CandyPointsScript : MonoBehaviour
{
    public Text candyText;

    public void candyOutOfStock()

    {
        ScoreManager.Instance.PointsShop = 0;
        candyText.text = "Grab a candy from the table!";
    }
}
