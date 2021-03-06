using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Animator panelGameOverAnim;
    public Text gameScore;
    public Text menuScore;
    public float maxDistanceBeforeLose = 10f;
    private float distance;
    public Transform target;
    public float startLimmit = 5f;
    private Vector3 targetPosition;
    public GameObject ScoreManager;
    public GameObject Player;
	
	

    public void GameOver()
    {
        panelGameOverAnim.SetTrigger("Open");
        //GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
        menuScore.text = gameScore.text;
        gameScore.gameObject.SetActive(false);
        
        
    }

    public void PlayAgain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    
    public void NextLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void LateUpdate()
    {
        if (ScoreManager.GetComponent<ScoreManager>().coin == 4)
        {
            GameOver();
        }
		
        distance = target.position.y - transform.position.y;

        if (target.position.y < startLimmit)
            return;
		
        if (distance < -maxDistanceBeforeLose)
        {
            GameOver();
        }
        else if (distance > 1)
        {
            targetPosition = new Vector3(0, target.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, distance*Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
        }
		
    }
}