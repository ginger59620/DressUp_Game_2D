using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DressingUpItem : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject drooped = eventData.pointerDrag;
        DraggableItem draggableItem = drooped.GetComponent<DraggableItem>();
        draggableItem.parentAfterDrag = transform;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
