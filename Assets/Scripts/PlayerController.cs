using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speedRun;
    private int jumbCount = 0;
    private bool canJumb = true;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.localPosition + Vector3.right * speedRun * Time.deltaTime;

        if(jumbCount == 2)
        {
            canJumb = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJumb)
        {
            rigidbody.velocity = Vector3.up * 7.5f;
            jumbCount++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumbCount = 0;
            canJumb = true;
        }

        if(collision.gameObject.tag == "Finish")
        {
            Time.timeScale = 0;
        }
    }
}
