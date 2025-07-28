using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public Transform RespawnPoint;
    // Start is called before the first frame update
    public int coinCount = 0;
    public int coinsInLevel = 0;
    public int _health = 3;
    public int _maxHealth = 3;
    private PlayerUIController _playerUIController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Death":
                {
                    _health--;
                    _playerUIController.UpdateHealth(_health, _maxHealth);
                    if (_health < 0)
                    {
                        
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);
                    }
                    else
                    {
                        transform.position = RespawnPoint.position;
                    }
                        break;
                }
            case "Finish":
                {
                    string nextLevel = other.GetComponent<LevelGoal>().nextLevel;
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    _playerUIController.UpdateText(coinCount + "/" + coinsInLevel);
                    Destroy(other.gameObject); 
                    break;
                }
            case "Health":
                {
                    if (_health < 3)
                    {
                        _health++;
                        Destroy(other.gameObject);
                    }
                    _playerUIController.UpdateHealth(_health, _maxHealth);
                    break;
                }
            case "Respawn":
                {
                    RespawnPoint.position = other.transform.Find("Point").position;
                    break;
                }
        }
    }
    private void Start()
    {
        coinsInLevel = GameObject.Find("Coins").transform.childCount;
            _playerUIController = GetComponent<PlayerUIController>();
        _playerUIController.StartUI();
        _playerUIController.UpdateHealth(_health, _maxHealth);
        _playerUIController.UpdateText(coinCount + "/" + coinsInLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
