using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{

    public TMP_Text _nameText;
    public TMP_Text _dialogueText;

    public Image _portrait;

    public Animator _dialogueAnimator;

    private Queue<string> _speeches;

    void Start()
    {
        _speeches = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {

        _dialogueAnimator.SetBool("IsOPen", true);

        _nameText.text = dialogue.name;

        _portrait.sprite = dialogue.portrait[0];

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
        _dialogueText.text = speeche;
    }



    void EndDialogue()
    {
        _dialogueAnimator.SetBool("IsOPen", false);

    }

}
