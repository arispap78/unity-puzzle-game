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
            transparent(tr.gameObject);
        }
    }

    void transparent(GameObject piece)
    {
        tempColor = piece.GetComponent<Renderer>().material.color;
        tempColor.a = 0f;
        piece.GetComponent<Renderer>().material.color = tempColor;
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
