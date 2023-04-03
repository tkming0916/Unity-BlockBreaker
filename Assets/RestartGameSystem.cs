using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGameSystem : MonoBehaviour
{

    //　スタートボタンを押したら実行する
    public void RestartGame()
    {
        SceneManager.LoadScene("Title");
    }
}
