using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuSCript : MonoBehaviour
{
    public InputField playerNameInputField;

    public void StartButtonClicked()
    {
        PersistentData.Instance.playerName = playerNameInputField.text;

        SceneManager.LoadScene(1);
    }
}
