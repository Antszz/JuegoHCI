using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ConectarCable : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;
    public GameObject cable;

    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;

    void Start()
    {
        char numberItem = gameObject.name[5];
        dragParent = GameObject.Find("DragParent"+numberItem).transform;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin");
        itemDragging = gameObject;
        Debug.Log(itemDragging.name);
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        cable.GetComponent<LineRenderer>().SetPosition(1, Camera.main.ScreenToWorldPoint(transform.position));
        Debug.Log(cable.GetComponent<LineRenderer>().GetPosition(1));
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("Final");
        itemDragging = null;
        
        if(transform.parent == dragParent)
        {
            transform.position = startPosition;
            transform.SetParent(startParent);
            cable.GetComponent<LineRenderer>().SetPosition(1, cable.GetComponent<LineRenderer>().GetPosition(0));
        }
    }
}
