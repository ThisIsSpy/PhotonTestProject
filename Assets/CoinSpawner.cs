using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coin;
    [SerializeField] private float minX, maxX, minY, maxY;
    [SerializeField] private int amount;

    private void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            Vector3 pos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            PhotonNetwork.Instantiate(coin.name, pos, Quaternion.identity);
        }
    }
}
