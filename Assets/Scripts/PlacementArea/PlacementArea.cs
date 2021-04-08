using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlacementArea : MonoBehaviour
{
    public List<GameObject> myPieces = new List<GameObject>();
    Color tempColor;

    GameObject test;

    public Action myNewAction;

    public Action<float> myNewerAction;

    /// <summary>
    /// This method executs at the VERY FIRST frame.
    /// </summary>
    private void OnEnable()
    {
        myNewAction += OnNewAction;
        myNewerAction += OnNewerAction;

        myNewerAction += OnNewerActionButDifferent;
    }

    public void OnNewerAction(float value)
    {
        Debug.Log($"on new action with value: {value}");
    }

    public void OnNewerActionButDifferent(float value)
    {
        Debug.Log($"on new action with value: {value + 1}");
    }

    /// <summary>
    /// Awake executes after the Very First frame
    /// </summary>
    private void Awake()
    {

    }

    /// <summary>
    /// Start of the Second Frame
    /// </summary>
    void Start()
    {
        myNewAction?.Invoke();

        myNewerAction.Invoke(3);

        foreach (Transform tr in transform)
        {
            myPieces.Add(tr.gameObject);
            MakePieceTransparent(tr.gameObject);
        }

    }

    /// <summary>
    /// From the Second frame and until we stop the SCENE.
    /// </summary>
    private void Update()
    {

    }

    public void OnNewAction()
    {
        Debug.Log("on new action");
    }



    public void MakePieceTransparent(GameObject piece)
    {
        tempColor = piece.GetComponent<Renderer>().material.color;
        tempColor.a = 0f;
        piece.GetComponent<Renderer>().material.color = tempColor;
    }

    private void OnMouseDown()
    {
        Debug.Log("hi");
        myNewerAction.Invoke(12.3f);
    }

    private void OnMouseDrag()
    {

    }

    private void OnMouseEnter()
    {

    }

    private void OnMouseOver()
    {

    }

    private void OnMouseUp()
    {

    }




    /// <summary>
    /// This method executs at the end of the LAST frame when the SCENE stops. Avoids memory leaking between Scenes
    /// </summary>
    private void OnDisable()
    {
        myNewAction -= OnNewAction;
        myNewerAction -= OnNewerAction;
    }
}
