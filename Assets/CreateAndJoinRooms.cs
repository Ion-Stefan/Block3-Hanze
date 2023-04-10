using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public string createInput;
    public string joinInput;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInput);
    }

    public void CreateOrJoinRoom()
    {
        StartCoroutine("CreateOrJoin");

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }

    IEnumerator CreateOrJoin()
    {
        PhotonNetwork.JoinRoom(joinInput);
        yield return new WaitForSecondsRealtime(3f);
        PhotonNetwork.CreateRoom(createInput);
    }



}
