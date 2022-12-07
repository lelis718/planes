using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnStartDelay = 5f;

    [SerializeField]
    private float _minSpawnTime = 1f;

    [SerializeField]
    private float _maxSpawnTime = 3f;

    [SerializeField]
    private float _spawnMargin = 10f;

    [SerializeField]
    private GameObject[] _objectsToSpawn;


    private float _nextSpawnTime = 0f;

    private float _minSpawnX = 0f;
    private float _maxSpawnX = 0f;
    private Vector3 _initialSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        SetSpawnPosition();
        SetInitialSpawnTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > _nextSpawnTime)
        {
            SetNextSpawnTime();
            SpawnRandomObject();
        }
    }

    private void SetSpawnPosition()
    {
        var cam = Camera.main;
        Vector3 position = cam.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height + 50, -cam.transform.position.z));
        _initialSpawnPosition = position;
        _minSpawnX = cam.ScreenToWorldPoint(new Vector3(_spawnMargin, 0, cam.transform.position.y)).x;
        _maxSpawnX = cam.ScreenToWorldPoint(new Vector3(Screen.width - _spawnMargin, 0, cam.transform.position.y)).x;
    }
    private void SetInitialSpawnTime()
    {
        _nextSpawnTime = Time.time + _spawnStartDelay;
    }
    private void SetNextSpawnTime()
    {
        _nextSpawnTime = Time.time + Random.Range(_minSpawnTime, _maxSpawnTime);
    }
    private void SpawnRandomObject()
    {
        var choosenObject = _objectsToSpawn[Random.Range(0, _objectsToSpawn.Length)];
        var randomPosition = Random.Range(_minSpawnX, _maxSpawnX);
        GameObject.Instantiate(choosenObject, new Vector3(randomPosition, _initialSpawnPosition.y, _initialSpawnPosition.z), this.transform.rotation);
    }
}
