using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textCounterCoin;

    [SerializeField] private GameObject panelLost;
    
    [SerializeField] Button buttonreloadLevel;
    
    [SerializeField] public GameObject winPanel;
    
   
    



    private void start()
    {
        winPanel.SetActive(false);
        UpdateCoinText(0);
    }

    public void UpdateCoinText(int newCoinCount)
    {
        textCounterCoin.text = newCoinCount.ToString();

        textCounterCoin.text = "Münze: " + newCoinCount;
    }

    public void ShowPanelLost()
    {
        panelLost.SetActive(true);
        buttonreloadLevel.onClick.AddListener(ReloadLevel);
    }

    public void ShowWinPanel()
    {
        winPanel.SetActive(true);
    }
    
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}







