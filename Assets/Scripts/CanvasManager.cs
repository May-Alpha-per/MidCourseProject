using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{
public TextMeshProUGUI Deathtext;
public TextMeshProUGUI WinText;
public Button GetHit;


        public void setWINText()
    {
        WinText.gameObject.SetActive(true);

    }
    public void setDeathText()
    {
        Deathtext.gameObject.SetActive(true);
        GetHit.gameObject.SetActive(true);

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
