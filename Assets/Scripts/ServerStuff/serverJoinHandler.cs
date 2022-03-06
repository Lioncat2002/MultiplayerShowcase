using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class serverJoinHandler : MonoBehaviourPunCallbacks
{
    public TMP_InputField nameInput;
    public TMP_InputField roomName;
    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        nameInput.text = "RandomPlayer";
        roomName.text = "RandomRoom";
    }
    public void JoinGame()
    {
        Connect();
    }
    public override void OnConnectedToMaster()
    {
        Join();
        base.OnConnectedToMaster();
    }
    public void Join()
    {
        if(roomName.text== "RandomRoom")
        {
            PhotonNetwork.JoinRandomRoom();
        }
        else
        {
            PhotonNetwork.JoinOrCreateRoom(roomName.text,null,null);
        }

        
    }
    public void Connect()
    {
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.LocalPlayer.NickName = nameInput.text;
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Create();
        base.OnJoinRandomFailed(returnCode, message);
    }
    public void Create()
    {
        PhotonNetwork.CreateRoom("");
    }
    public override void OnJoinedRoom()
    {
        //Debug.Log($"Player { PhotonNetwork.CurrentRoom.PlayerCount}");

        StartGame();
        base.OnJoinedRoom();
    }
    public void StartGame()
    {

        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {

            PhotonNetwork.LoadLevel(1);
        }

    }
}
