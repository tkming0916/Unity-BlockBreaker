
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene("Main");
	}

	public void EndGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;
		//Application.OpenURL("http://www.yahoo.co.jp/");
		Application.Quit();
	}

}
