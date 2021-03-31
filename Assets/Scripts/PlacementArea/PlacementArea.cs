using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementArea : MonoBehaviour
{
    public List<GameObject> myPieces = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform tr in transform) 
        {
            myPieces.Add(tr.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
