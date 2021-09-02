using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject dust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            //GameManager.instance.GameOver();
            //GameObject.Find("Player").GetComponent<PlayerController>().PlayDeadAnim();
            // Destroy(collision.gameObject, 2f);
            GameManager.instance.DecreaseLife();
            Destroy(gameObject);
            if (GameManager.instance.lives <= 0)
            {
                GameManager.instance.GameOver();
               GameObject.Find("Player").GetComponent<PlayerController>().PlayDeadAnim();
                GameObject.Find("Player").GetComponent<PlayerController>().PlayMusic();
                Destroy(collision.gameObject, 2f);
            }
            else
            {
                GameObject.Find("Player").GetComponent<PlayerController>().PlayMusic();
                GameObject.Find("Player").GetComponent<PlayerController>().PlayDamageAnim();
            }

        }
        if (collision.CompareTag("Ground"))
            
        {
            
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
            GameObject effect = Instantiate(dust, transform.position, Quaternion.identity);
            Destroy(effect, 3f);
        }
    }
}
