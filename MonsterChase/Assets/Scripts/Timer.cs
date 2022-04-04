
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	public Text TimerText;
	public bool playing;
	private float UITIMER;

	void Update()
	{

		if (playing == true)
		{

		UITIMER += Time.deltaTime;
			int minutes = Mathf.FloorToInt(UITIMER / 60F);
			int seconds = Mathf.FloorToInt(UITIMER % 60F);
			int milliseconds = Mathf.FloorToInt((UITIMER * 100F) % 100F);
			TimerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
		}

	}

}