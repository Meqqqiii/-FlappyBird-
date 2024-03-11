using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int Playerscore;
    public Text ScoreText;
    public GameObject gameoverScreen;
    public AudioSource ding;
    [ContextMenu("Increase Score")]
    public void addscore(int scoretoadd)
    {
        Playerscore = Playerscore + scoretoadd;
        ScoreText.text = Playerscore.ToString();
        ding.Play();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameoverScreen.SetActive(true);
    }
}
