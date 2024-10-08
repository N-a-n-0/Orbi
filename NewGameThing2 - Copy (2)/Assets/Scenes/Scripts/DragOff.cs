using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DragOff : MonoBehaviour
{
    public static void DOff()
    {
        for (int i = 0; i < GameObject.Find("Object Holder").transform.childCount; i++)
        {
             GameObject.Find("Object Holder").transform.GetChild(i).gameObject.GetComponent<Drag>().enabled = false;
        }
        
        GameObject.Find("CircleC").transform.gameObject.GetComponent<Button>().enabled= false;
        GameObject.Find("TriangleC").transform.gameObject.GetComponent<Button>().enabled= false;
        GameObject.Find("SquareC").transform.gameObject.GetComponent<Button>().enabled= false;


    }

    public static void DOn()
    {
        for (int i = 0; i < GameObject.Find("Object Holder").transform.childCount; i++)
        {
            GameObject.Find("Object Holder").transform.GetChild(i).GetComponent<Drag>().enabled = true;
        }
        GameObject.Find("CircleC").transform.gameObject.GetComponent<Button>().enabled= true;
        GameObject.Find("TriangleC").transform.gameObject.GetComponent<Button>().enabled= true;
        GameObject.Find("SquareC").transform.gameObject.GetComponent<Button>().enabled= true;
    }

    
    
    
}
