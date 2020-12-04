using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Button : MonoBehaviour
{
    public GameObject TodoCanvas;
    public GameObject CardPrefab;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        //GameObject newCard = Instantiate(CardPrefab);
        //Card card = newCard.GetComponent<Card>;
        //newCard.transform.Find("Title").gameObject.GetComponent<Text>().text = "Click to add";
        //newCard.transform.SetParent(TodoCanvas.transform);
        Debug.Log("Added new event");
    }
}
