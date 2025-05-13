using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float minX, maxX, minY, maxY;

    private void Start()
    {
        Vector3 pos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        PhotonNetwork.Instantiate(player.name, pos, Quaternion.identity);
    }
}
