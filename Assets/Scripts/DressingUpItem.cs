using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DressingUpItem : MonoBehaviour //, IDropHandler
{
    public AudioSource source;
    public AudioClip shineComplete;

    public void Placed()
    {
        source.PlayOneShot(shineComplete);
    }

   /* public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
       // draggableItem.parentAfterDrag = transform;
        
    }*/
}

  
   