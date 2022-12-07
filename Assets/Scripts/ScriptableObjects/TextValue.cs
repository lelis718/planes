using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Objects / Text Value")]
public class TextValue : ScriptableObject
{
    [TextArea(3,10)]
    public string Value;
}
