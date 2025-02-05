using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _backGrPanel;

    [SerializeField] private int _level;

    private bool _pause;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PauseGame();
        }
    }

    public void RestartLevel() // ����� ������������� �������
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadLevel() // ����� ��������� ������� ����� �������� ������ � ����������
    {
        SceneManager.LoadScene(_level);
    }

    public void LoadMainMenu() // ����� ��������� ������� ����
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame() // ����� ������ ���� �� �����, ���� ���� ��� �� ����� �� ������� �
    {
        if (!_pause)
            Time.timeScale = 0;
        else if (_pause)
            Time.timeScale = 1;

        _pause = !_pause;
    }

    public void GameOver() // ����� ���������� ��������� ������ �� ������
    {
        _gameOverPanel.SetActive(true);
        _backGrPanel.SetActive(false);
    }

    public void ExitGeme() // ����� ��������� ����������
    {
        Application.Quit();
    }
}
