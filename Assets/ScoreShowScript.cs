using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreShowScript : MonoBehaviour
{
    public Text textObject;
    void Update()
    {
        textObject.text = "Points: " + ScoreManager.Instance.PointsShop;
    }
}
