using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {

static private Player instance;
static public Player Instance{
	get{ 
		if (instance == null) {
			instance = new Player ();
		}
		return instance;
	}
}
private Player(){



}

public GameController gCtrl;

private int score = 0;
private int life = 3;

public int Score{
	get{ return score; }
	set{ 
		score = value;
		gCtrl.updateUI();
	}

}

public int Life{
	get{ return life; }
	set{ 
		life = value;


		if (life <= 0) {
			//game over
			gCtrl.gameOver();
		}else{
			gCtrl.updateUI();
		}
	}
}
}
