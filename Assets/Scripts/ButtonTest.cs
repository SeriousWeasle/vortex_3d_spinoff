using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonTest : MonoBehaviour
{
    public Image background; //background color
    public Text selectedMode; //text displaying diff in center of screen
    public GameObject[] circles; //array of circles in main menu

    private void Start()
    {
        UpdateMenu(0); //on start select easy
    }

    public void UpdateMenu(int idx)
    {
        //there probably is a better way to do this, but I am scared of Unity's UI elements so this has to do
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
            case 4: //quit button
                background.color = new Color(0f, 0f, 0.6f);
                selectedMode.color = new Color(0f, 0f, 0.4f);
                selectedMode.text = "Quit game";
                break;
            default: //default to easy
                background.color = new Color(0.6f, 0f, 0.6f);
                selectedMode.color = new Color(0.4f, 0f, 0.4f);
                selectedMode.text = "Easy";
                break;
        }

        for (int i = 0; i < circles.Length; i++)
        {
            if (i == idx) //if circle corresponds to difficulty
            {
                circles[i].SetActive(true);
                print(i);
            }
            else //if it does not
            {
                circles[i].SetActive(false);
            }
        }
    }
    public void selectEasy()
    {
        SceneManager.LoadScene(1); //load scene idx 1 from build settings
    }

    public void selectNormal()
    {
        SceneManager.LoadScene(2); //load scene idx 2 from build settings
    }

    public void selectHard()
    {
        SceneManager.LoadScene(3); //load scene idx 3 from build settings
    }

    public void selectVeryHard()
    {
        SceneManager.LoadScene(4); //load scene idx 4 from build settings
    }
}
