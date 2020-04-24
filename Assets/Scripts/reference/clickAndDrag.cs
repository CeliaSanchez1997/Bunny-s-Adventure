using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickAndDrag : MonoBehaviour
{

    private float startPoX;
    private float startPoY;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
       if(isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPoX, mousePos.y - startPoY, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPoX = mousePos.x - this.transform.localPosition.x;
            startPoY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
