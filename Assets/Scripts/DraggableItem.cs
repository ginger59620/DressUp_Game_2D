using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DraggableItem : MonoBehaviour //, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public SpriteRenderer rendered;

    public AudioSource source;
    public AudioClip prickUp, dropOff;

    private bool dragging;

    private Vector2 offset, originalPosition;

    private DressingUpItem _slot;

    public void Init(DressingUpItem slot)
    {
        rendered.sprite = slot.Renderer.sprite;
        _slot = slot;
    }

    void Awake()
    {
        originalPosition = transform.position;
    }

    void Update()
    {
        if (!dragging) return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - offset;
    }
    void OnMouseDown()
    {
        dragging = true;
        source.PlayOneShot(prickUp);

        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp()
    {
        //if(Vector2.Distance(transform.position, slot))

        transform.position = originalPosition;
        dragging = false;
        source.PlayOneShot(dropOff);
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }



    

    /*public Image image;
    [HideInInspector] public Transform parentAfterDrag;


    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Start Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();

        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);

        image.raycastTarget = true;
    }*/
}
