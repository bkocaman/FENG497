using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static int coin;
	public Text textScore;
	public int current_score;

	void Start()
	{
		textScore.text = "Score: 0";
		current_score = 0;
		
	}

	void Update()
	{
		textScore.text = "Score: " + coin.ToString();
		
	}
	

	
}












/*public int getScore()
    {
		return current_score;
    }
	
	public void UpdateScore (int score) 
	{
		current_score = (score / 3) * 10;
		textScore.text = "Score: " + current_score;
	}
*/
