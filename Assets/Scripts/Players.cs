using UnityEngine;

public class Players : MonoBehaviour
{
    [Header("Settings")]
    public float JumpForce;

    [Header("References")]
    public Rigidbody2D PlayerRigidBody;
    public Animator PlayerAnimator;

    public BoxCollider2D PlayerCollider;

    private bool isGrounded = true;
    private int lives = 3;
    private bool isInvincible  = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            PlayerRigidBody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isGrounded = false;
            PlayerAnimator.SetInteger("State", 1); // Jumping state
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            if (!isGrounded)
            {
                PlayerAnimator.SetInteger("State", 2);
            }
            isGrounded = true;

        }
    }

    void KillPlayer()
    {
        PlayerCollider.enabled = false;
        PlayerAnimator.enabled = false;
        PlayerRigidBody.AddForceY(JumpForce,ForceMode2D.Impulse);  

    }


    void Hit()
    {
        lives--;
        if(lives <= 0)
        {
            KillPlayer();
        }
    }

    void Heal()
    {
        lives = Mathf.Min(3, lives + 1);
    }

    void StartInvincible()
    {
        isInvincible = true;
        Invoke("StopInvincible", 5);
    }

    void StopInvincible()
    {
        isInvincible = false;
    }
void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if(!isInvincible)
            {
                Destroy(GetComponent<Collider>().gameObject);
                Hit();
            }

        }
        else if (collision.gameObject.CompareTag("food"))
        {
            Destroy(collision.gameObject);
            Heal();
        }
        else if (collision.gameObject.CompareTag("golden")) 
        {
            Destroy(collision.gameObject);
            StartInvincible();

           
        }
    }
}
