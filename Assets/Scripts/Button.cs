using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Sprite butt_on, butt_off;

	void OnMouseDown()
	{	
		gameObject.GetComponent<Image>().sprite = butt_on;
		
	}

	void OnMouseUp()
	{
		gameObject.GetComponent<Image>().sprite = butt_off;
	}

	void OnMouseUpAsButton()
	{
		switch (gameObject.name)
		{
			case "ButtonPlay":
				SceneManager.LoadScene("Game");
				break;
			
		}
	}


}

