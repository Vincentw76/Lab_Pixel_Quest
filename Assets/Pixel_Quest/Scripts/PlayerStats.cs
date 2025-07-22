using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextLevel = "Scene_2";
    // Start is called before the first frame update
    public int coinCount = 0;
    public int _health = 3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        switch (other.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
            case "Coin":
                {
                    coinCount++;
                    Destroy(other.gameObject); 
                    break;
                }
            case "Heath":
                {
                    _health++;
                    Destroy(other.gameObject);
                    break;
                }
        }
    }
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
