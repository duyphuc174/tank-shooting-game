using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    public TMP_InputField inputField;
    public static string nameInput;
    // Start is called before the first frame update
    public void loadScene()
    {
        SceneManager.LoadScene("SampleScene");
    }


    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit The Game");
    }
}
