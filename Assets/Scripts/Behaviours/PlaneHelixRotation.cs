using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHelixRotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationSpeed = 2f;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, _rotationSpeed));
    }

}
