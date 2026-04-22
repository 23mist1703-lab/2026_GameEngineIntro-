using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
public void ButtonLog()
    {
        Debug.Log("BUTTON CLICKED!");

        SceneManager.LoadScene("Level_1");
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
