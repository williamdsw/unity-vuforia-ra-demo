using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScene : MonoBehaviour
{
    // || Inspector References

    [Header("UI Canvas Elements")]
    [SerializeField] private Button beginButton;
    [SerializeField] private Button quitButton;

    private void Awake()
    {
        CheckReferences();
        SetEventListeners();
    }

    private void CheckReferences()
    {
        if (!beginButton)
        {
            throw new Exception("BeginButton is null!");
        }

        if (!quitButton)
        {
            throw new Exception("QuitButton is null!");
        }
    }

    private void SetEventListeners()
    {
        beginButton.onClick.AddListener(() => GotoNextScene(GlobalReferences.ScenesNames.VuforiaDemoScene));
        quitButton.onClick.AddListener(OnQuit);
    }

    private void GotoNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnQuit()
    {
        Application.Quit();
    }
}
