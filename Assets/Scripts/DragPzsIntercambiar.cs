using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragPzsIntercambiar : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public Vector3 startPosition;
    public Vector3 homePosition;
    public Text strCantPzs;
    public int cantPzs;
    // Start is called before the first frame update
    void Start()
    {
        homePosition = transform.position;
        if(gameObject.name == "Pz1")
            cantPzs = 26;
        if(gameObject.name == "Pz2")
            cantPzs = 35;
        if(gameObject.name == "Pz3")
            cantPzs = 29;
        if(gameObject.name == "Pz4")
            cantPzs = 42;

    }

    // Update is called once per frame
    void Update()
    {
        strCantPzs.text = "x"+cantPzs.ToString();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
        cantPzs--;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 positionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        positionMouse.z = 0;
        transform.position = positionMouse;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = startPosition;
        if(transform.position == homePosition)
            cantPzs++;
    }

}
