using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class List : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData){
        Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData){
        Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log( eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d!=null){
            d.parentToReturnTo = this.transform;
        }
    }
}
