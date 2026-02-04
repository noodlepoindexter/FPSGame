using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using System.Collections;

public class MLevelManager : MonoBehaviour
{

    public int requiredNumberOfKills = 3;
    private int soFar = 0;

    public string nextLevelName = "Level2";

    [SerializeField] MKillCountUI killCountUI;

    [SerializeField] private GameObject YouWonUI;
    
    void Start()
    {
        FindFirstObjectByType<MEnemyManager>().OnEnemyDied.AddListener(OnEnemyDeath);
    }

    public void OnEnemyDeath(GameObject enemy)
    {
        soFar++;
        this.winLevelIfNeeded();

        Assert.IsNotNull(killCountUI);
        killCountUI.SetKillCount(soFar, requiredNumberOfKills);
    }

    private void winLevelIfNeeded()
    {
        if (soFar >= requiredNumberOfKills)
        {
            Debug.Log("Level Won!"); 
            // SceneManager.LoadScene(nextLevelName);
            StartCoroutine(FadeThenLoad());
        }
    }

    IEnumerator FadeThenLoad()
    {
        YouWonUI.SetActive(true);
        yield return new WaitForSeconds(5f);
        YouWonUI.SetActive(false);
        SceneManager.LoadScene(nextLevelName);
    }

    public void OnPlayerDeath()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
    
}
