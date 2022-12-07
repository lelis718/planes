using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectRemover : MonoBehaviour
{
    private Vector3 removalReference;
    private void Start()
    {
        Camera cam = Camera.main;
        removalReference = cam.ScreenToWorldPoint(new Vector3(0, -50f, cam.transform.position.y));
    }

    private void Update()
    {
        if (this.transform.position.y < removalReference.y)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

}
