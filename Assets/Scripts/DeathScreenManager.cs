using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class DeathScreenManager : MonoBehaviour
{
    public GameObject deathScreen; // ������ ������ ������

    private void Start()
    {
        // ��������, ��� ����� ������ �������� � ������
        deathScreen.SetActive(false);
    }

    public void ShowDeathScreen()
    {
        deathScreen.SetActive(true);
        Time.timeScale = 0f; // ������������� ����
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f; // ������������ �����
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ������������� ������� �������
    }
}