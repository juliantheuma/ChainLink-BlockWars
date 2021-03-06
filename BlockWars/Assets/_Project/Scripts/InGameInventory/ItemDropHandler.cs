using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropHandler : MonoBehaviour, IDropHandler
{
    public InGameInventory _Inventory;
    public void OnDrop(PointerEventData eventData)
    {
        RectTransform invPanel = transform as RectTransform;

        if(!RectTransformUtility.RectangleContainsScreenPoint(invPanel, Input.mousePosition))
        {
            IInGameInventoryItem item = eventData.pointerDrag.gameObject.GetComponent<ItemDragHandler>().Item;
            Debug.Log("Drop item");

            if(item != null)
            {
                _Inventory.RemoveItem(item);
                item.OnDrop();
            }
        }
    }
}
