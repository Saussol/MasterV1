using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiGestion : MonoBehaviour
{
    private RandomSeedController seedController;

    public TextMeshProUGUI[] texts;
    public TMP_InputField inputField;
    

    private void Start()
    {
        seedController = GetComponent<RandomSeedController>();
    }

    public void OnClickRandomGeneration()
    {
        seedController.GenerateRandomSeed();
        inputField.text = seedController.GetCurrentSeed();
        RandomNumber();
    }
    
    public void OnClickSetSeed()
    {
        seedController.SetRandomSeed(inputField.text);
        RandomNumber();
    }

    private void RandomNumber()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            int randomValue = Random.Range(0, 100);
            texts[i].text = randomValue.ToString();
        }
    }
}
