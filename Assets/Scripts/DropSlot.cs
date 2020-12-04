using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropSlot : MonoBehaviour, IDropHandler
{
    public GameObject item;
    public GameObject control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = ConectarCable.itemDragging;
            if (item.name[5] == gameObject.name[4]) 
            {
                control.GetComponent<ControlAyudante>().setCableCompleted(item.name[5]);
                item.transform.SetParent(transform);
                item.transform.position = transform.position;
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}
