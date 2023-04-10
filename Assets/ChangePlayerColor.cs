using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColor : MonoBehaviour
{
    public Material initialMat;
    public Material firstMat;
    public Material secondMat;
    public Material thirdMat;
    public Material fourthMat;
    public Material fifthMat;
    public Material sixthMat;
    public Material seventhMat;
    public Material eighthMat;
    public Material ninethMat;
    public Material tenthMat;
    private float randomNumber;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(1, 10);
        randomNumber = Mathf.FloorToInt(randomNumber);
        if (randomNumber == 1)
        {
            GetComponent<Renderer>().material = firstMat;
        }
        if (randomNumber == 2)
        {
            GetComponent<Renderer>().material = secondMat;
        }
        if (randomNumber == 3)
        {
            GetComponent<Renderer>().material = thirdMat;
        }
        if (randomNumber == 4)
        {
            GetComponent<Renderer>().material = fourthMat;
        }
        if (randomNumber == 5)
        {
            GetComponent<Renderer>().material = sixthMat;
        }
        if (randomNumber == 6)
        {
            GetComponent<Renderer>().material = seventhMat;
        }
        if (randomNumber == 7)
        {
            GetComponent<Renderer>().material = eighthMat;
        }
        if (randomNumber == 8)
        {
            GetComponent<Renderer>().material = ninethMat;
        }
        if (randomNumber == 9)
        {
            GetComponent<Renderer>().material = tenthMat;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
