using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;

    public Sprite[] portrait;


    [TextArea(3, 8)]
    [NonReorderable]
    public string[] _speeches;

}