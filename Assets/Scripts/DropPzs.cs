using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPzs : MonoBehaviour, IDropHandler
{
    public bool existPz;
    public GameObject pzDrop;
    public GameObject btnCanjear;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDrop(PointerEventData eventData)
    {
        if(existPz){
            pzDrop.GetComponent<DragPzsIntercambiar>().startPosition = pzDrop.GetComponent<DragPzsIntercambiar>().homePosition;
            pzDrop.GetComponent<DragPzsIntercambiar>().cantPzs++;
            pzDrop.GetComponent<Transform>().position = pzDrop.GetComponent<DragPzsIntercambiar>().homePosition;
        }
        pzDrop = eventData.pointerDrag;
        eventData.pointerDrag.GetComponent<DragPzsIntercambiar>().startPosition = transform.position;
        existPz = true;
        btnCanjear.SetActive(true);
        Debug.Log(eventData.pointerDrag);
    }
}
