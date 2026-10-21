using UnityEngine;
using UnityEngine.SceneManagement;
public class Control : MonoBehaviour
{
    private int sceneNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneNumber = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ResetGame()
    {
        SceneManager.LoadScene("Level_1");
    }
}
