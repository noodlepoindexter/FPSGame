using UnityEngine;

public class MIntroSceneManager : MonoBehaviour
{
    
    public void HandleStartButtonClicked()
    {
        Debug.Log("Start Button Clicked!");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
