using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    bool youLose = false;

    [SerializeField] private float restartDelay; 

    public void GameOver()
    {
        if (youLose == false)
        {
            youLose = true;
            Debug.Log("You Lose....Loser!");
            Invoke(nameof(Restart), restartDelay);
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
          
    }

}
