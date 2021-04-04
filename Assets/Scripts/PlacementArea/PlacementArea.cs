using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementArea : MonoBehaviour
{
    public List<GameObject> myPieces = new List<GameObject>();
    Color tempColor;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform tr in transform) 
        {
            myPieces.Add(tr.gameObject);
            tempColor=tr.gameObject.GetComponent<Renderer>().material.color;
            tempColor.a = 0f;
            tr.gameObject.GetComponent<Renderer>().material.color = tempColor;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
