
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text scoreText;
    public Text winText;
    public Text livesText;

    private Rigidbody rb;
    private int count;
    private int score;
    private int lives = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            score = score + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Hurty Boi"))
        {
            other.gameObject.SetActive(false);
            score = score - 1;
            lives = lives - 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "TOTAL: " + count.ToString();
        scoreText.text = "SCORE: " + score.ToString();
        livesText.text = "LIVES: " + lives.ToString();
        if(lives == 0)
        {
            winText.text = "You Lost All Your Lives!";
            rb.gameObject.SetActive(false);


        }
        if (count == 8)
        {
            Vector3 position = new Vector3(0, 1, 100);
            rb.position = position;
            winText.text = "Level  2";
        }
        if (count == 9)
        {
          
            winText.text = " ";
        }
        if (count == 16)
        {
            winText.text = "You did it!";
        }
    }
}