using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Button : MonoBehaviour
{
    public GameObject TodoCanvas;
    public GameObject CardPrefab;
    public void OnPointerClick()
    {
        GameObject newCard = Instantiate(CardPrefab);
        //Debug.Log("Created new card");
        newCard.transform.SetParent(TodoCanvas.transform);
        newCard.transform.localScale = new Vector3(1,1,1);
    }
}
