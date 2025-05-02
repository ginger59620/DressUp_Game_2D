using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPickUp : MonoBehaviour
{
    public GameObject itemPrefab; // Assign your item prefab here
    private GameObject pickedUpItem;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.CompareTag("PickUp"))
            {
                PickUpItem(hit.collider.gameObject);
            }
        }

        if (Input.GetMouseButtonUp(0) && pickedUpItem != null)
        {
            ReleaseItem();
        }
    }

    void PickUpItem(GameObject item)
    {
        pickedUpItem = Instantiate(itemPrefab, item.transform.position, item.transform.rotation);
        pickedUpItem.transform.SetParent(transform); // Parent to the player
        item.SetActive(false); // Hide the original item
    }

    void ReleaseItem()
    {
        pickedUpItem.transform.SetParent(null);
        Destroy(pickedUpItem); // Destroy the duplicated item after release
        pickedUpItem = null;
    }
}
