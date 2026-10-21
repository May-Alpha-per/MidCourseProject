using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasManager : MonoBehaviour
{
public TextMeshProUGUI Deathtext;

public GameObject gameOverUI;


    public void setDeathText()
    {
        Deathtext.gameObject.SetActive(true);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
