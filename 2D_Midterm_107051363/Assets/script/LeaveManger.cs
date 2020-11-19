using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveManger : MonoBehaviour
{
    public void NextLeavel(string nameLV)
    {
        SceneManager.LoadScene(nameLV);
    }
    public void BacktoMene()
    {
        SceneManager.LoadScene("選單");
            
    }
    public void Quit()
    {
        Application.Quit();
    }
}
