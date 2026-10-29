using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI coinText;
    public GameObject winPanel;

    private int coins = 0;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    void Start()
    {
        if (winPanel != null) winPanel.SetActive(false);
        UpdateCoinUI();
    }

    public void AddCoin()
    {
        coins++;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        if (coinText != null) coinText.text = "Coins: " + coins;
    }

    public void LevelComplete()
    {
        if (winPanel != null) winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}