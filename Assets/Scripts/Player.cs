using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 100;
    public int points = 0;
    public TextMeshProUGUI scoreText;
    public bool allow = true;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (rb.velocity.y <= 0)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        if(rb.velocity.y > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -30);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (allow)
        {
            if (points < 10)
            {
                scoreText.text = "000" + (++points).ToString();
            }
            else if (points < 100)
            {
                scoreText.text = "00" + (++points).ToString();
            }
            else if (points < 1000)
            {
                scoreText.text = "0" + (++points).ToString();
            }
            else
            {
                scoreText.text = (++points).ToString();
            }
        }
    }
    
    void OnCollisionStay2D(Collision2D collision)
    {
        points = 0;
        scoreText.text = "0000";
    }
}
