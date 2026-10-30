using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    [SerializeField] private Life playerLife;
    [SerializeField] private Life playerBaseLife;

    private bool gameOver = false;

    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemyManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);
    }

    void OnPlayerOrBaseDied()
    {
        if (gameOver) return;
        gameOver = true;
        SceneManager.LoadScene("LoseScreen");
    }

    void CheckWinCondition()
    {
        if (gameOver) return;

        if (EnemyManager.instance.enemies.Count <= 0 &&
            WavesManager.instance.waves.Count <= 0)
        {
            gameOver = true;
            SceneManager.LoadScene("WinScreen");
        }
    }
}