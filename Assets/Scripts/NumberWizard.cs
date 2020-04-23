using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min = -1;
    [SerializeField] int max = -1;

    [SerializeField] TextMeshProUGUI guessText = null;

    [SerializeField] Button btnHigher = null;
    [SerializeField] Button btnLower = null;

    int guess = -1;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();

        if (min >= max)
        {
            btnHigher.interactable = false;
            btnLower.interactable = false;
        }
    }
}
