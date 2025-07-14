
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_2";



    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
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
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }

    }
}   
