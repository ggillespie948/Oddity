﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridCell : MonoBehaviour {

    private Renderer rend;
    public int x;
    public int y;
    public GridTile cellTile;

    public Color highlightColour;


    void Awake()
    {
        rend = GetComponent<Renderer>();



        
    }

    void Start()
    {
        GameMaster.instance.objGameGrid[x, y] = this;
        
    }

    public void OnMouseEnter()
    {

        GameMaster.instance.activeCell = this;
        //rend.material.color = Color.green;
        int centre = BoardController.instance.GRID_SIZE-1;
        centre = (centre/2);

        if((x==centre) && y==centre)
            rend.material.color = highlightColour;
    }

    public void OnMouseExit()
    {
        //Color def = new Color();
        //ColorUtility.TryParseHtmlString("#07003FFF", out def);
        //rend.material.color = startCol;

        int centre = BoardController.instance.GRID_SIZE-1;
        centre = (centre/2);

        if((x==centre) && y==centre)
            rend.material.color = highlightColour;

        if(GameMaster.instance.activeCell != null)
        {
            GameMaster.instance.activeCell = null;

        }

    }

    public void OnMouseDown()
    {
        //if(this.cellTile!=null)
        //    BoardController.instance.CheckTileValidity(this); //temp
    }


}