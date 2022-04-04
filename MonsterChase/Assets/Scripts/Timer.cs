using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text TimerText;
	public bool playing;
	private float UITimer;

	void Update()
	{

		if (playing == true)
		{

			UITimer += Time.deltaTime;
			int minutes = Mathf.FloorToInt(UITimer / 60F);
			int seconds = Mathf.FloorToInt(UITimer % 60F);
			int milliseconds = Mathf.FloorToInt((UITimer * 100F) % 100F);
			TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		}

	}

}