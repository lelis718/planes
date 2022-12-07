using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private FloatValue _scoreReference;
    
    [SerializeField]
    private GameObject _restartObject;
    // Start is called before the first frame update
    void Start()
    {
        _scoreReference.Value = 0;
        _restartObject.SetActive(false);
    }

    public void DisplayRestartObject()
    {
        _restartObject.SetActive(true);
    }

    private void Awake()
    {
        Instance = this;
    }
    public static GameManager Instance { get; private set; }
}
