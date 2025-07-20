using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void BackToTheMenu() 
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
