using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField]
    private float MinSpeed = 5f;

    [SerializeField]
    private float MaxSpeed = 15f;

    private float Speed = 0f;

    void Start()
    {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

    void Update()
    {
        Vector3 velocity = Vector3.down * Speed * Time.deltaTime;
        transform.position = transform.position + velocity;
    }
}
