using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class GameManager : MonoBehaviour
{
    
    [SerializeField]GameObject respawnButton;
    [SerializeField]GameObject gamePanel;
    [SerializeField]GameObject winPanel;
    [SerializeField]GameObject gameOverPanel;

    [SerializeField] TMP_Text livesCounter;
    [SerializeField] GameObject[] maps;
    int lives = 5;
    int currentMap = 0;
    void Start()
    {
        respawnButton.SetActive(true);
        gamePanel.SetActive(true);
        winPanel.SetActive(false);
        gameOverPanel.SetActive(false);
        livesCounter.text = "Vidas: "+lives;        
        
    }
    public void LoseLife()
    {
        if(lives <= 0)
        {
            GameOver();
        }
        else 
        {
            lives--;
            respawnButton.SetActive(true);
        }
        livesCounter.text = "Vidas: "+lives;
    }
    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        winPanel.SetActive(false);
        gamePanel.SetActive(false);
        respawnButton.SetActive(false);
    }
    private void WinScreen()
    {
        gamePanel.SetActive(false);
        winPanel.SetActive(true);
        gameOverPanel.SetActive(false);
    }
    public void Restart()
    {
        lives = 5;
        currentMap = 0;
        respawnButton.SetActive(true);
        gamePanel.SetActive(true);
        ChangeMap(0);
        livesCounter.text = "Vidas: "+lives;

    }
    public void AdvanceLevel()
    {
        currentMap++;
        if(currentMap >= 3)
        {
            WinScreen();
        }
        else
        {
            ChangeMap(currentMap);
            respawnButton.SetActive(true);
        }
    }
    public void ChangeMap(int mapIndex)
    {
        foreach (var map in maps)
        {
            map.SetActive(false);
        }
        maps[mapIndex].SetActive(true);
    }
}
