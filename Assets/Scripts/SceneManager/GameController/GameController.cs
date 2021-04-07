using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameController : MonoBehaviour
{
    public PlacementArea[] activeAreas;// = new List<PlacementArea>();
    string[] children = new string[] { "red", "blue", "yellow", "green", "brown" };
    public string visiblePiece;
    public int choice;

    // Start is called before the first frame update
    private void Awake()
    {
        activeAreas = FindObjectsOfType<PlacementArea>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        getPiecename();
        match();
        Debug.Log($"areas: {activeAreas.Length}");
        //Console.Write($"name: {children[choice]}");

    }

    void getPiecename()
    {
        var rand = new System.Random();
        choice = rand.Next(children.Length);
        visiblePiece = children[choice];
    }

    void match()
    {
        foreach (PlacementArea area in activeAreas)
        {
            if (area.name.Equals("Central"))
            {
                foreach (GameObject fit in area.myPieces) 
                {
                    if(fit.name== visiblePiece)
                        makeVisible(fit);
                }  
            }
        }
    }
    void makeVisible(GameObject piece)
    {
        Color tempColor = piece.GetComponent<Renderer>().material.color;
        tempColor.a = 1f;
        piece.GetComponent<Renderer>().material.color = tempColor;
    }
}
