using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlacementArea[] activeAreas;// = new List<PlacementArea>();
    string[] children = new string[] { "red", "blue", "yellow", "green", "brown" };
    public int choice;
    // Start is called before the first frame update
    private void Awake()
    {
        activeAreas = FindObjectsOfType<PlacementArea>();
    }

    // Update is called once per frame
    void Update()
    {
        var rand = new System.Random();
        choice = rand.Next(children.Length);
        System.Console.Write($"name: {children[choice]}");
    }
}
