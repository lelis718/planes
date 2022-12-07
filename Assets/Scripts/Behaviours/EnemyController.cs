using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private string _playerTag = "Player";

    [SerializeField]
    private FloatValue _scoreReference;

    [SerializeField]
    private GameObject _explosion;


    [SerializeField]
    private float _pointsToAdd = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            _scoreReference.Value += _pointsToAdd;

            var objectInstantiated = GameObject.Instantiate(_explosion, this.transform.position, Quaternion.identity);
            var particle = objectInstantiated.GetComponent<ParticleSystem>().main;
            var color = this.gameObject.GetComponentInChildren<Renderer>().material.color;
            color.a = 100;
            particle.startColor = new ParticleSystem.MinMaxGradient(color);

            GameObject.Destroy(this.gameObject);
        }
    }
}
