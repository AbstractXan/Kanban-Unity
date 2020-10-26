using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler 
{

    public Transform parentToReturnTo = null;
    bool isDragged=false;
    public void OnBeginDrag(PointerEventData eventData){
        //Debug.Log("OnBeginDrag");
        isDragged = true;

        // Change mouse raycast interaction
        GetComponent<CanvasGroup>().blocksRaycasts = false;

        // Return to parent
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent( this.transform.parent.parent );
    }

    public void OnDrag(PointerEventData eventData){
        //Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData){
        Debug.Log("OnEndDrag");
        isDragged = false;

        // Change mouse raycast interaction
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        
        this.transform.SetParent( parentToReturnTo );
    }

    void Update()
    {
        if(isDragged){
            this.transform.position = (Vector2) Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
