using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    // Reference to the Button component
    public Button exitButton;

    void Start()
    {
        // Ensure the button is assigned
        if (exitButton != null)
        {
            exitButton.onClick.AddListener(ExitGame);
        }
        else
        {
            Debug.LogError("Exit button is not assigned!");
        }
    }

    void ExitGame()
    {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }
}
