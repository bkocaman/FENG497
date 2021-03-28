using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Animator panelGameOverAnim;
	public Text gameScore;
	public Text menuScore;

    public void GameOver()
	{
		panelGameOverAnim.SetTrigger("Open");
		GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
		menuScore.text = gameScore.text;
		gameScore.gameObject.SetActive(false);
	}

	public void PlayAgain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);
	}
}
