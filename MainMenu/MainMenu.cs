using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [Header("UI Elements")]
    public Button playButton;
    public Button optionsButton;
    public Button creditsButton;
    public Button exitButton;

    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;
    public GameObject exitConfirmationPanel;

    [Header("Scene to Load")]
    public string gameSceneName;

    private void Start()
    {
        // Ensure that the main menu is displayed at the start
        ShowMainMenu();
    }

    public void Play()
    {
        // Load the game scene when the "Play" button is pressed
        SceneManager.LoadScene(gameSceneName);
    }

    public void Options()
    {
        // Show the Options panel and hide other panels
        optionsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(false);
        exitConfirmationPanel.SetActive(false);
    }

    public void Credits()
    {
        // Show the Credits panel and hide other panels
        creditsPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        exitConfirmationPanel.SetActive(false);
    }

    public void BackToMainMenu()
    {
        // Show the main menu panel and hide other panels
        ShowMainMenu();
    }

    public void Exit()
    {
        // Show the exit confirmation panel
        exitConfirmationPanel.SetActive(true);
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
    }

    public void ConfirmExit()
    {
        // Quit the application when the "Yes" button in the exit confirmation panel is pressed
        Application.Quit();
    }

    public void CancelExit()
    {
        // Show the main menu when the exit confirmation is canceled
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        // Show the main menu panel and hide other panels
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        exitConfirmationPanel.SetActive(false);
    }
}
