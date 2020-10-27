using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public string title = "List";

    void Update(){
        transform.Find("Text").gameObject.GetComponent<Text>().text = title;
    }
}
