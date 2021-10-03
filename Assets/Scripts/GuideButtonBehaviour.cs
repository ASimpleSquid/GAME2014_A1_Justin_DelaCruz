///////////////////////////////
/// GuideButtonBehaviour.cs
/// Justin Dela Cruz
/// 101127646
/// Last Modified: 2021-10-03
/// This .cs file makes a button go back
/// to the main menu screen
/// GAME2014 - Assignment 1
//////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideButtonBehaviour : MonoBehaviour
{
    public void OnGuideButtonPressed()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
}
