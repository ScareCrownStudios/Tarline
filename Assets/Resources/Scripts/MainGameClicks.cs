﻿using UnityEngine;
using System.Collections;

public class MainGameClicks : MonoBehaviour {
	GameObject player;
	public Sprite Retry_Down;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	//	Retry_Down = Resources.Load ("Sprites/Ui/Retry_Up") as Sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		//handle normal rotate clicks
		switch(MainGameManager.current_game_state){
			case MainGameManager.game_state.PreStart:
			MainGameManager.Start_Game();
			break;
			case MainGameManager.game_state.Playing:
			if (player.GetComponent<Animator> ().GetBool ("RotatedUp") == true) {
				player.GetComponent<Animator> ().SetBool ("RotatedUp", false);
				player.GetComponent<Animator> ().Play ("MainGame_TarCar_RotateToDown");
			} else {
				player.GetComponent<Animator> ().SetBool ("RotatedUp", true);
				player.GetComponent<Animator> ().Play ("MainGame_TarCar_RotateToUp");
				
			}
			break;
		case MainGameManager.game_state.GameOver:

			//GameObject.FindGameObjectWithTag ("RetryButton").GetComponent<SpriteRenderer> ().sprite = Retry_Down;
			//Debug.Break ();
			break;

	}
	}
}
