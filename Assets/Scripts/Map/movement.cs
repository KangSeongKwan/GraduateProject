using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Transform movePoint;
    public LayerMask Stopmovement;
    public bool click = true;
    private Rigidbody2D rigidBody;
    private Vector2 vector;
    public Vector3 pos;
    public float posX;
    public GameObject spot;
    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
        if (GameObject.Find("player").GetComponent<Click_Move>().click)
        {
            if (player_random.move_point != 0)
            {
                if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
                {
                    if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
                    {
                        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f), .2f, Stopmovement))
                        {
                            movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                            player_random.move_point--;
                            GameObject.Find("player").GetComponent<Click_Move>().Buttonoff();
                        }
                    }
                    else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
                    {
                        if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, Stopmovement))
                        {
                            movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                            player_random.move_point--;
                            GameObject.Find("player").GetComponent<Click_Move>().Buttonoff();
                        }
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "dark")
        {
            Destroy(other.gameObject);
        }
    }
}

