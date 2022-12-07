using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneStarter : MonoBehaviour
{
    [SerializeField]
    private float _speed = 20f;

    private PlaneMovement _planeMovement;
    private Vector3 _startDestination;
    private Vector3 _startPosition;


    // Start is called before the first frame update
    void Awake()
    {
        _planeMovement = GetComponent<PlaneMovement>();
    }
    private void Start()
    {
        Camera cam = Camera.main;
        _planeMovement.enabled = false;
        _startDestination = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, cam.nearClipPlane));
        _startDestination.z = 0;
        _startPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, -2f, cam.nearClipPlane));
        _startPosition.z = 0;
        this.transform.position = _startPosition;
    }
    // Update is called once per frame
    void Update()
    {
        var velocity = Vector3.ClampMagnitude(_startDestination - this.transform.position, _speed * Time.deltaTime);
        velocity.z = 0;
        this.transform.position = this.transform.position + velocity;

        if (velocity.magnitude < 0.001 || Input.GetMouseButton(0))
        {
            StartControlling();
        }
    }

    void StartControlling()
    {
        _planeMovement.enabled = true;
        this.enabled = false;
    }
}
