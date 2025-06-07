using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class DeathScreenManager : MonoBehaviour
{
    public GameObject deathScreen; // Панель экрана смерти

    private void Start()
    {
        // Убедимся, что экран смерти выключен в начале
        deathScreen.SetActive(false);
    }

    public void ShowDeathScreen()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0f; // Останавливаем игру
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // Возобновляем время
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Перезапускаем текущий уровень
    }
}