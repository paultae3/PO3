using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{

    private Queue<string> _speeches;

    void Start()
    {
        _speeches = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        Debug.Log("Starting conversation with" + dialogue.name);

        _speeches.Clear();

        foreach (string speeche in dialogue._speeches)
        {
            _speeches.Enqueue(speeche);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {

        if (_speeches.Count == 0)
        {

            EndDialogue();
            return;

        }

        string speeche = _speeches.Dequeue();
        Debug.Log(speeche);
    }

    void EndDialogue()
    {
        Debug.Log("End of Conversation");
    }

}
