using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void ButtonClicked()
    {
        SceneManager.LoadScene("HanaCharenge");
    }
}