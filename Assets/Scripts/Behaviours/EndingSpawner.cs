using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSpawner : MonoBehaviour
{
    [SerializeField]
    private float _endingSpawnTime = 128f;

    [SerializeField]
    private GameObject _endingObject;


    private float _spawnTime = 0f;
    private bool _spawnned = false;

    void Start()
    {
        _spawnTime = _endingSpawnTime + Time.time;
        _spawnned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _spawnTime && !_spawnned)
        {
            SpawnEndingObject();
        }
    }

    private void SpawnEndingObject()
    {
        var cam = Camera.main;
        Vector3 position = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height + 200, -cam.transform.position.z));
        GameObject.Instantiate(_endingObject, position, this.transform.rotation);
        _spawnned = true;
    }
}
