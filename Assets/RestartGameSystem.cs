using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGameSystem : MonoBehaviour
{

    //�@�X�^�[�g�{�^��������������s����
    public void RestartGame()
    {
        SceneManager.LoadScene("Title");
    }
}
