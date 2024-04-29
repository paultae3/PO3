using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    [Tooltip("Name of this NPC that will be displayed on dialogue box.")]
    public string name;

    [Tooltip("Portrait of this NPC that will be displayed on dialogue image. You can only add one element on this section.")]
    public Sprite[] portrait;

    [Tooltip("Greeting Sound when player interact with NPC. You can only add one element on this section.")]
    public AudioClip[] audio;


    [TextArea(3, 8)]
    [NonReorderable]
    [Tooltip("Speeches of this NPC. You can add element size(number of speech) as many as you want.")]
    public string[] _speeches;

}