using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUIController : MonoBehaviour
{
    private Image _health;
    private TextMeshProUGUI _text;
    // Start is called before the first frame update
    public void UpdateText(string newtext)
    {
        _text.text = newtext;
    }
    public void StartUI()
    {
        _health = GameObject.Find("heart").GetComponent<Image>();
         _text = GameObject.Find("CoinText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        _health.fillAmount = currentHealth / maxHealth;
    }
}
