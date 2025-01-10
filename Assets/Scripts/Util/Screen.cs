using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screen : MonoBehaviour
{
    
    /// <summary>
    /// 씬 이동
    /// </summary>
    /// <param name="sceneName"> 씬 이름<br/>
    /// 씬이 빌드 설정에 포함되지 않을 경우 동작하지 않음
    /// </param>
    public void MoveScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    /// <summary>
    /// 게임 종료 <br/>
    /// </summary>
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
