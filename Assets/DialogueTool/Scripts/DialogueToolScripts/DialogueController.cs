using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{

    [Header("UI Editor")]

    [Tooltip("This is the text area where the name of NPC displays.")]
    public TMP_Text _nameText;

    [Tooltip("This is the text area where NPC's speeches displays.")]
    public TMP_Text _dialogueText;

    [Tooltip("This is image area where NPC's portrait displays.")]
    public Image _portrait;

    [Tooltip("You can leave this one blank. You will edit audio on NPC itself.")]
    public AudioClip _audio = null;

    [Tooltip("If you use the Dialogue Canvas provided on prefab, you will drag Dialogue Box under Dialogue Canvas to this area. " +
        "It will make dialogue box appears when triggering by player and disappears when dialogue ends.")]
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

        AudioHelper.PlayClip2D(_audio = dialogue.audio[0], 1);

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
