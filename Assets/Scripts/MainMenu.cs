﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public Text playerText;
	public Cursor[] cursors;

	
    void Start()
    {
		Statics.numberOfPlayers = 2;
		playerText.text = Statics.numberOfPlayers.ToString();
		cursors[2].gameObject.SetActive(false);
		cursors[3].gameObject.SetActive(false);
    }

	public void ChangePlayers(int i)
	{
		if(i>0&&Statics.numberOfPlayers<4||i<0&&Statics.numberOfPlayers>2)
		{
			Statics.numberOfPlayers += i;
			playerText.text = Statics.numberOfPlayers.ToString();
			if (i > 0)
			{
				cursors[Statics.numberOfPlayers - 1].gameObject.SetActive(true);
			}
			else
			{
				cursors[Statics.numberOfPlayers].gameObject.SetActive(false);
			}
		}
	}

	public void StartGame()
	{
		SceneManager.LoadScene("Level1");
	}
   
}
