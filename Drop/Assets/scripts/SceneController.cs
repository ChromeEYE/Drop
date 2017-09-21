using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    //シーン移動
   public void Loadscene(string SceneName)
    {
        Debug.Log(SceneName);
        SceneManager.LoadScene(SceneName); 
    }

    //ゲームを終了
    public void GameEnd()
    {
        Debug.Log("ゲームを終了");
        Application.Quit();
    }
}
