using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

    public Dialogue _localDialogue;

    public void OnTriggerEnter(Collider other)
    {


        DialogueController dialogueController = other.gameObject.GetComponent<DialogueController>();

        if (dialogueController != null)
        {
            dialogueController.StartDialogue(_localDialogue);

            Debug.Log("test test");
        }

    }

}