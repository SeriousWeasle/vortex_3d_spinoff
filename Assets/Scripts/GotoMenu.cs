using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoMenu : MonoBehaviour
{
    public void gotoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
