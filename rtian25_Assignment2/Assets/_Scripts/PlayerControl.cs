using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    float moveVert, moveHoriz;
    Rigidbody rb;
    int score, point;
    public Text text;
    bool pickedUp;

    public int Point
    {
        get { return point; }
        set { point = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rb = GetComponent<Rigidbody>();
        UpdateScore();
    }


    private void OnTriggerEnter(Collider other)
    {
        pickedUp = false;
        if (other.gameObject.CompareTag("PickupGreen"))
        {
            Point = 5;
            pickedUp = true;
        }
        else if (other.gameObject.CompareTag("PickupRed"))
        {
            Point = 10;
            pickedUp = true;
        }
        else if (other.gameObject.CompareTag("PickupBlue"))
        {
            Point = 2;
            pickedUp = true;
        }

        if (pickedUp)
        {
            score += Point;
            Destroy(other.gameObject);
            UpdateScore();
        }

    }

    void FixedUpdate()
    {
        moveHoriz = Input.GetAxis("Horizontal");
        moveVert = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(moveHoriz, 0f, moveVert) * speed);
    }

    void UpdateScore()
    {
        text.text = "Score: " + score.ToString();
    }
}
