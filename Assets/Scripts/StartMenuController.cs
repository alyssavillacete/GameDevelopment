using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartMenuController : MonoBehaviour {

	[SerializeField]
	Button startBtn;

	public void StartBtnClick() {
		SceneManager.LoadScene ("Scenes/main");
	}
}
