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

    public void RestartLevel() // Метод перезагружает уровень
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadLevel() // Метод загружает уровень номер которого указан в инспекторе
    {
        SceneManager.LoadScene(_level);
    }

    public void LoadMainMenu() // Метод загружает главное меню
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame() // Метод ставит игру на паузу, если игра уже на паузе то снимает её
    {
        if (!_pause)
            Time.timeScale = 0;
        else if (_pause)
            Time.timeScale = 1;

        _pause = !_pause;
    }

    public void GameOver() // Метод активирует финальную панель со счетом
    {
        _gameOverPanel.SetActive(true);
        _backGrPanel.SetActive(false);
    }

    public void ExitGeme() // Метод закрывает приложение
    {
        Application.Quit();
    }
}
