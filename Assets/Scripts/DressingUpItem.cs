using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DressingUpItem : MonoBehaviour //, IDropHandler
{
    public SpriteRenderer Renderer;

    public AudioSource source;
    public AudioClip shineComplete;

    public void Placed()
    {
        source.PlayOneShot(shineComplete);
    }

    internal void Init(DressingUpItem spawnedSlot)
    {
        
    }

    /* public void OnDrop(PointerEventData eventData)
     {
         GameObject dropped = eventData.pointerDrag;
         DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
        // draggableItem.parentAfterDrag = transform;

     }*/
}

  
   