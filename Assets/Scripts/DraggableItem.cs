using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DraggableItem : MonoBehaviour 
{
    //audio variables
    public AudioSource source;
    public AudioClip prickUp, dropOff;
    //Variables
    public GameObject correctForm;
    private bool moving;
    private bool finish;
    //Mouse position variable
    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = this.transform.localPosition; 
    }

    void Update()
    {

        //if (finish == false)
        
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        
    }

    private void OnMouseDown()
    {
        source.PlayOneShot(prickUp);

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        source.PlayOneShot(dropOff);
        moving = false; 

        /*if (Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= 0.1f && Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= 0.1f)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }*/
    }
}
