using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text levelText;
    public TMP_Text healthText;
    public TMP_Text expText;
    public GameObject gameoverPanel;
	// Start is called before the first frame update
	public void SetLevelText(string text)
    {
        if(levelText)
        {
            levelText.text = text;
        }
    }

    public void SetHealthText(string text)
    {
        if(healthText)
        {
            healthText.text = text;
        }
    }

	public void SetExpText(string text)
	{
		if (expText)
		{
			expText.text = text;
		}
	}

    public void ShowGameOverPanel(bool isShow)
    {
        if(gameoverPanel)
        {
            gameoverPanel.SetActive(isShow);
        }
    }
}
