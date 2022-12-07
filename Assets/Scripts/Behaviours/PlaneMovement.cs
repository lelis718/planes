using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 20f;

    private Camera _camera;

    public Vector3 Velocity { get; private set; }
    void Start()
    {
        _camera = Camera.main;
    }
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 position = _camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -_camera.transform.position.z));
            Velocity = Vector3.ClampMagnitude(position - this.transform.position, _speed * Time.deltaTime);
            this.transform.position = this.transform.position + Velocity;
        }
        else
        {
            Velocity = Vector3.zero;
        }


    }
}
