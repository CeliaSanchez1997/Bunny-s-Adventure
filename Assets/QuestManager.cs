using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public QuestObject[] quest;
    public bool[] questCompleted;

    public DialogManager theDM;

    public string itemCollected;
    public string enemyKilled;

    // Start is called before the first frame update
    void Start()
    {
        questCompleted = new bool[quest.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowQuestText(string questText)
    {
        theDM.dialogLines = new string[1];
        theDM.dialogLines[0] = questText;

        theDM.currentLine = 0;
        theDM.ShowDialogue();
    }
}
