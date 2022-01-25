using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField _roomInputField;
    [SerializeField] private TMP_Text _errorText;
    [SerializeField] private TMP_Text _RoomNameText;
    private void Start()
    {
    
        Debug.Log("Connecting To Master Server");
       Photon.Pun.PhotonNetwork.ConnectUsingSettings();
       MenuManager.instance.OpenMenu("loading");
    }
    public override void OnJoinedLobby() {
        Debug.Log("Connected To Master Server");
        MenuManager.instance.OpenMenu("Title2");
        
    }
    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(_roomInputField.text))
        {
            return;
        }
        PhotonNetwork.CreateRoom(_roomInputField.text);
        MenuManager.instance.OpenMenu("loading");
    }
    public override void OnJoinedRoom()
    {
        _RoomNameText.text=PhotonNetwork.CurrentRoom.Name;
        MenuManager.instance.OpenMenu("Room");
    }
    public override void OnCreateRoomFailed(short returnCode, string message){
        _errorText.text ="Error:"+ message;
        MenuManager.instance.OpenMenu("Title2");
    }

}
