using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogueCharacter
{
    public string name;
    public Sprite icon;
}

[System.Serializable]
public class DialogueLine
{
    public DialogueCharacter character;
    [TextArea(3, 10)]
    public string line;
}

[System.Serializable]
public class DialogueAlternate
{
    public List<DialogueLine> dialogueLines = new List<DialogueLine>();
}
public class DialogueAlternateTrigger : MonoBehaviour
{
    public DialogueAlternate dialogue;

    public void TriggerDialogueAlternate()
    {
        DialogueAlternateManager.Instance.StartDialogueAlternate(dialogue);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //if (collision.tag == "Player")
    //{
    //    TriggerDialogueAlternate();
    //}
    //}

     void Start()
    {
        TriggerDialogueAlternate();
    }

}
