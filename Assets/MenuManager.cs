using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField createInputField;
    [SerializeField] TMP_InputField joinInputField;

    public void CreateRoom()
    {
        RoomOptions options = new();
        options.MaxPlayers = 2;
        PhotonNetwork.CreateRoom(createInputField.text, options);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinInputField.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Main");
    }
}
