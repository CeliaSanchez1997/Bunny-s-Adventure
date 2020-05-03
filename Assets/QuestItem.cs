using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestItem : MonoBehaviour
{
    public int questNum;
    private QuestManager theQM;
    public string itemName;

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
        if(collision.gameObject.name == "Player_side")
        {
            if(!theQM.questCompleted[questNum] && theQM.quest[questNum].gameObject.activeSelf)
            {
                theQM.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }

        else if (collision.gameObject.name == "Player")
        {
            if (!theQM.questCompleted[questNum] && theQM.quest[questNum].gameObject.activeSelf)
            {
                theQM.itemCollected = itemName;
                gameObject.SetActive(false);
            }
        }
    }
}
