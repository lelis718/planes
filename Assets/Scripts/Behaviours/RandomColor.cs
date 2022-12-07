using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    [SerializeField]
    private Color[] possibleColors;


    private void Start()
    {
        var choosenColor = possibleColors[Random.Range(0, possibleColors.Length)];
        gameObject.GetComponentInChildren<Renderer>().material.color = choosenColor;
    }
}
