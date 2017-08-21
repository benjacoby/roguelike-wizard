﻿using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		SetupUI ();
	}

	void SetupUI()
	{
		Cell[,] board = BoardManager.instance.BOARD;
		print (board.GetLength(0));
		print (board.GetLength(1));

		for (int xi = 0; xi < board.GetLength (0); xi++) {
			for (int yi = 0; yi < board.GetLength (1); yi++) {
				GameObject cell = Instantiate (Resources.Load ("CellEmpty"),new Vector3(board[xi,yi].POSITION.X,board[xi,yi].POSITION.Y,0), Quaternion.identity) as GameObject;
				cell.transform.SetParent (transform);
			}
		}
	}





}