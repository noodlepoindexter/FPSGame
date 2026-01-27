using UnityEngine;

public class MKillCountUI : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI killCountText;


    public void SetKillCount(int count, int total)
    {
        killCountText.text = "Kills: " + count.ToString() + " / " + total.ToString();
    }
    

}
