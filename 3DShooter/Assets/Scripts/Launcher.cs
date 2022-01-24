using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        Debug.Log("ConnectedToMasterServer");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("ConnectedToMasterServer");
        PhotonNetwork.JoinLobby();
    }
 
    public override void OnJoinedLobby()
    {
        Debug.Log("Присоединились к лобби");
    }

}
