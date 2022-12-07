using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotation : MonoBehaviour
{
    [SerializeField]
    private float _rotationAngle = 10f;

    [SerializeField]
    private float _rotationSpeed = 2f;

    private PlaneMovement planeMovement;
    // Start is called before the first frame update
    void Awake()
    {
        planeMovement = GetComponent<PlaneMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = Vector3.zero;
        if (planeMovement.Velocity.x > 0)
        {
            angle = new Vector3(0, -_rotationAngle, 0);
        }
        if (planeMovement.Velocity.x < 0)
        {
            angle = new Vector3(0, _rotationAngle, 0);
        }

        Quaternion newRotation = Quaternion.Euler(angle);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, _rotationSpeed * Time.deltaTime);

    }
}
