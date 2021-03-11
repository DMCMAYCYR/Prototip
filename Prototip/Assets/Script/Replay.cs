using UnityEngine.SceneManagement;
using UnityEngine;

public class Replay : MonoBehaviour
{
   public void Yeniden()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }
}
