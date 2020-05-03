using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogAcive;

    public string[] dialogLines;
    public int currentLine;

    private Top_Down_Movement player;

    void Start()
    {
        player = FindObjectOfType<Top_Down_Movement>();
    }

    void Update()
    {
        if(dialogAcive && Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogAcive = false;
            currentLine++;
        }

        if(currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogAcive = false;

            currentLine = 0;
            //player.canMove = true;
        }
        dText.text = dialogLines[currentLine];
    }

    public void ShowBox(string dialogue)
    {
        dialogAcive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogue()
    {
        dialogAcive = true;
        dBox.SetActive(true);
        //player.canMove = false;

    }
}
