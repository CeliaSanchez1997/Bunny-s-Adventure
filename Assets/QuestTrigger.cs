using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTrigger : MonoBehaviour
{
    private QuestManager theQM;
    public int questNumbers;

    public bool startQuest;
    public bool endQuest;

    // Start is called before the first frame update
    void Start()
    {
        theQM = FindObjectOfType<QuestManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player_side")
        {
            if(!theQM.questCompleted[questNumbers])
            {
                if(startQuest && theQM.quest[questNumbers].gameObject.activeSelf)
                {
                    theQM.quest[questNumbers].gameObject.SetActive(true);
                    theQM.quest[questNumbers].StartQuest();
                }

                if(endQuest && theQM.quest[questNumbers].gameObject.activeSelf)
                {
                    theQM.quest[questNumbers].EndQuest();
                }
            }
        }

        else if (collision.gameObject.name == "Player")
        {
            if (!theQM.questCompleted[questNumbers])
            {
                if (startQuest && theQM.quest[questNumbers].gameObject.activeSelf)
                {
                    theQM.quest[questNumbers].gameObject.SetActive(true);
                    theQM.quest[questNumbers].StartQuest();
                }

                if (endQuest && theQM.quest[questNumbers].gameObject.activeSelf)
                {
                    theQM.quest[questNumbers].EndQuest();
                }
            }
        }
    }
}
