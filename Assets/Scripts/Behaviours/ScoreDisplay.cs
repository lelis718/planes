using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private FloatValue _scoreReference;
    private TMPro.TextMeshProUGUI _textMesh;
    // Start is called before the first frame update
    void Awake()
    {
        _textMesh = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        _textMesh.text = _scoreReference.Value.ToString();
    }
}
