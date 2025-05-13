using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ServerConnection : MonoBehaviourPunCallbacks
{
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Menu");
    }
}
