using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlacementArea[] activeAreas;// = new List<PlacementArea>();
    // Start is called before the first frame update
    private void Awake()
    {
        activeAreas = FindObjectsOfType<PlacementArea>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
