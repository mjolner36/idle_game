using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Sprite butt_on, butt_off;
	AudioSource click;

	private void Start()
    {
       click = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();

    }


    void OnMouseDown()
	{	
		gameObject.GetComponent<Image>().sprite = butt_on;

		click.Play();

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
			case "exit":
				Application.Quit();
				break;
			case "caption":
				SceneManager.LoadScene("Сaption");
				break;
			case "record":
				SceneManager.LoadScene("Game");
				break;
		}



		
	}


}

