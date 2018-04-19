﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour {

	[Header("Tutorial Dialogues")]
	public GameObject OpeningDialogue;
	public GameObject OddTotalDialogue;
	public GameObject DragTilesDialogue;
	public GameObject InactiveTileGesture;
	public GameObject InactiveTileDialogue;
	public GameObject EndTurnDialogue;
	public GameObject SwapTilesDialogue;
	public GameObject GoodLuckDialogue;

	[Header("Tutorial Checkpoints")]
	public bool clear1;
	public bool clear2;
	public bool clear3;

	public bool clear4;

	public bool clear5;

	[Header("Tutorial Tiles")]
	public GridTile tile1;
	public GridTile tile2;
	public GridTile tile3;

	public void StartTutorial()
	{
		OpeningDialogue.SetActive(true);
		GameMaster.instance.Player1Hand.Add(tile1);
		GameMaster.instance.Player1Hand.Add(tile2);
		GameMaster.instance.Player1Hand.Add(tile3);
		// GameMaster.instance.StateMachine.SetLastValidState(1);
		// GameMaster.instance.turnIndicator=1;
		// GameMaster.instance.humanTurn = true;
	}

	public void Clear1()
	{
		OpeningDialogue.SetActive(false);
		OddTotalDialogue.SetActive(true);

	}

	public void Clear2()
	{
		OddTotalDialogue.SetActive(false);
		DragTilesDialogue.SetActive(true);
		tile1.gameObject.SetActive(true);
		tile2.gameObject.SetActive(true);
		tile3.gameObject.SetActive(true);
		tile1.GetComponent<BoxCollider2D>().enabled = false;
		tile3.GetComponent<BoxCollider2D>().enabled = false;

		//Deal player hand 121, set last valid state
		//disable box coliders on all tiles bar 1 tile
	}

	public void Clear3()
	{
		clear3 = true;
		DragTilesDialogue.SetActive(false);
		InactiveTileGesture.SetActive(true);
		tile1.GetComponent<BoxCollider2D>().enabled = true;
	}

	public void Clear4()
	{
		clear4 = true;
		InactiveTileDialogue.SetActive(true);
		InactiveTileGesture.SetActive(false);
	}

	public void Clear5()
	{
		clear5 = true;
		InactiveTileDialogue.SetActive(false);
	}

	public void Clear6()
	{
		EndTurnDialogue.SetActive(true);
	}

	public void Clear7()
	{
		EndTurnDialogue.SetActive(false);
		SwapTilesDialogue.SetActive(true);
	}

	public void Clear8()
	{
		SwapTilesDialogue.SetActive(false);
		GoodLuckDialogue.SetActive(true);
		Destroy(GoodLuckDialogue.gameObject, 3.75f);
		GameMaster.instance.TUTORIAL_MODE = false;
	}
}
