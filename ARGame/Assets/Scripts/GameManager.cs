using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Tmpro → TMPro (대소문자 정확히)

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI drawText; // ← 여기 수정
    public bool isDrawing = false;

    int i = 0;

    public void GameOver()
    {
        Application.Quit();
    }

    public void ChangeDrawButton()
    {
        i = (i + 1) % 2;
        if (i == 1)
        {
            drawText.text = "Stop";
            isDrawing = true;
        }
        else
        {
            drawText.text = "Draw";
            isDrawing = false;
        }
    }
}
