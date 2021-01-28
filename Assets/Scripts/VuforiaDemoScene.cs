using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VuforiaDemoScene : MonoBehaviour
{
    // || Inspector References

    [Header("UI Canvas Elements")]
    [SerializeField] private Button backButton;

    private void Awake()
    {
        CheckReferences();
        SetEventListeners();
    }

    private void CheckReferences()
    {
        if (!backButton)
        {
            throw new Exception("BackButton is null!");
        }
    }

    private void SetEventListeners()
    {
        backButton.onClick.AddListener(() => GotoNextScene(GlobalReferences.ScenesNames.IntroScene));
    }

    private void GotoNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
