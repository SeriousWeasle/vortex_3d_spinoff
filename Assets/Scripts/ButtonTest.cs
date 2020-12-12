using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Image background;
    public Text selectedMode;
    public GameObject[] circles;

    private void Start()
    {
        UpdateMenu(0);
    }

    public void UpdateMenu(int idx)
    {
        switch(idx)
        {
            case 0: //easy
                background.color = new Color(0.6f, 0f, 0.6f);
                selectedMode.color = new Color(0.4f, 0f, 0.4f);
                selectedMode.text = "Easy";
                break;
            case 1: //normal
                background.color = new Color(0f, 0.6f, 0f);
                selectedMode.color = new Color(0f, 0.4f, 0f);
                selectedMode.text = "Normal";
                break;
            case 2: //hard
                background.color = new Color(0.6f, 0f, 0f);
                selectedMode.color =new Color(0.4f, 0f, 0f);
                selectedMode.text = "Hard";
                break;
            case 3: //very hard
                background.color = new Color(0.2f, 0.2f, 0.2f);
                selectedMode.color = new Color(0f, 0f, 0f);
                selectedMode.text = "Very Hard";
                break;
            default: //default to easy
                background.color = new Color(0.6f, 0f, 0.6f);
                selectedMode.color = new Color(0.4f, 0f, 0.4f);
                selectedMode.text = "Easy";
                break;
        }

        for (int i = 0; i < circles.Length; i++)
        {
            if (i == idx)
            {
                circles[i].SetActive(true);
                print(i);
            }
            else
            {
                circles[i].SetActive(false);
            }
        }
    }
    public void selectEasy()
    {
        SceneManager.LoadScene(1);
    }

    public void selectNormal()
    {
        Debug.Log("selected normal");
    }

    public void selectHard()
    {
        Debug.Log("selected hard");
    }

    public void selectVeryHard()
    {
        Debug.Log("selected very hard");
    }
}
