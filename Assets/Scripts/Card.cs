using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public string title = "Some Task";

    // Get CardTitle child object
    // Get Text Component of the above
    void Update(){
        transform.Find("Title").gameObject.GetComponent<Text>().text = title;
    }
}
