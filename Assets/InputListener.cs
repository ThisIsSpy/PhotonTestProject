using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class InputListener : MonoBehaviourPun
{
    private Rigidbody rb;
    private PhotonView phView;
    private TextMeshPro counterText;
    private int counter;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        phView = GetComponent<PhotonView>();
        counterText = GetComponentInChildren<TextMeshPro>();
        counter = 0;
    }

    void Update()
    {
        if (!phView.IsMine) return;
        if (rb != null) ListenForMovementInput();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent(out Coin _))
        {
            counter++;
            counterText.text = counter.ToString();
            PhotonNetwork.Destroy(collision.gameObject);
        }
    }

    private void ListenForMovementInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
            rb.AddForce(new(0, 10, 0));
        else if (Input.GetKeyDown(KeyCode.D))
            rb.AddForce(new(10, 0, 0));
        else if (Input.GetKeyDown(KeyCode.S))
            rb.AddForce(new(0, -10, 0));
        else if (Input.GetKeyDown(KeyCode.A))
            rb.AddForce(new(-10, 0, 0));
        else if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = Vector3.zero;
    }
}
