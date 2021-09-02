using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    SpriteRenderer sp;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
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
        MovePlayer();

    }

    public void PlayDeadAnim()
    {
        animator.Play("DEAD");
    }
    public void PlayDamageAnim()
    {
        animator.Play("DAMAGE");
    }

    public void PlayMusic()
    {
        audioSource.Play();
    }

    private void MovePlayer()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2)
            {
                //left
                animator.SetTrigger("RUN");
                rb.velocity = Vector2.left * moveSpeed;
                sp.flipX = true;
            }
            else
            {
                //right
                animator.SetTrigger("RUN");
                rb.velocity = Vector2.right * moveSpeed;
                sp.flipX = false;
            }
        }
        else
        {
            animator.SetTrigger("STAY");
            rb.velocity = Vector2.zero;
          
        }
    }
}
