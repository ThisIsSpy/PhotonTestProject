using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody RB { get; private set; }

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }
}
