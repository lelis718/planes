using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController : MonoBehaviour
{
    [SerializeField]
    private string _playerTag = "Player";


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_playerTag))
        {
            other.gameObject.SetActive(false);
            GameManager.Instance.DisplayRestartObject();
        }
    }
}
