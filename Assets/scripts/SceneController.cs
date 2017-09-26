using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static int publicId;

    //シーン移動
   public void Loadscene(int id)
    {
        publicId = id;
        SceneManager.LoadScene("Game"); 
    }

    //ゲームを終了
    public void GameEnd()
    {
        Debug.Log("ゲームを終了");
        Application.Quit();
    }
}
