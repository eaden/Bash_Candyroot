using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update

    public void goto_startGame()
    {
        SceneManager.LoadScene("Level1");
        
    }
    public void goto_zweitesLevel()
    {
        SceneManager.LoadScene("DasErste");

    }
    public void goto_endGame()
    {
        Application.Quit();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
