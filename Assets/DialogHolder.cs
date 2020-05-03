using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogHolder : MonoBehaviour
{
    public string dialog;
    private DialogManager dMan;

    public string[] dialogueLines;

    // Start is called before the first frame update
    void Start()
    {
        dMan = FindObjectOfType<DialogManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player_side")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                //dMan.ShowBox(dialog);
                if(!dMan.dialogAcive)
                {
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
                if(transform.parent.GetComponent<NPCMovement>() != null)
                {
                    transform.parent.GetComponent<NPCMovement>().canMove = false;
                }
            }
        }
    }
}
