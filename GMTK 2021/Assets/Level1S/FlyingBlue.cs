using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlyingBlue : MonoBehaviour
{
    public float FlyingSpeed = 10f;
    public float Health = 1;
    private bool IsTouchingGround;
    public Transform FlyingBluePos;
    public LayerMask Ground;
    private bool FlyingBlueIsTouchingGround;
    WalkingRed walkingred;
    public float speed = 3f;
    // Update is called once per frame
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    private float oldPosistion;
    public bool GoingDown;
    Fininshed F;
    private void Awake()
    {
        F = GameObject.Find("Fininshed").GetComponent<Fininshed>();
        walkingred = GameObject.Find("WalkingRed").GetComponent<WalkingRed>(); 
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        oldPosistion = transform.position.y;
    }

    private void Update()
    {
        if (oldPosistion > gameObject.transform.position.y)
        {
            GoingDown = true;
        }
        if (oldPosistion < gameObject.transform.position.y)
        {
            GoingDown = false;
        }
        oldPosistion = transform.position.y;
        movement.y = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        animator.SetBool("IsTouchingGround", FlyingBlueIsTouchingGround);
        animator.SetBool("GoingDown", GoingDown);

        bool IsTouchingGround = Physics2D.OverlapCircle(FlyingBluePos.position, 0.4f, Ground);
        if (walkingred.Freeze == false)
        {

            if (F.TimesFininshed == 0)
            {
                rb.MovePosition(rb.position + movement * FlyingSpeed * Time.fixedDeltaTime);
            }
            else
            {
                rb.MovePosition(rb.position + movement * FlyingSpeed * F.TimesFininshed * Time.fixedDeltaTime);
            }
            if (IsTouchingGround)
            {
                FlyingBlueIsTouchingGround = true;
            }
            if (!IsTouchingGround)
            {
                FlyingBlueIsTouchingGround = false;
            }
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
