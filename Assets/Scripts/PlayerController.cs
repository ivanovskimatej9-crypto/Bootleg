using UnityEngine;  

public class PlayerController : MonoBehaviour 
{
  public float moveSpeed;
  public float JumpForce;
  private Rigidbody2D _rigidbody2d;
  private float horizontalInput;
  private bool isJumpPressed;

  private void Awake()
  {
    _rigidbody2d = GetComponent<Rigidbody2D>();
  }

  private void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    if (Input.GetKeyDown(KeyCode.Space))
    { 
      isJumpPressed = true;
    }
    Debug.Log("Horizontal Input: " + horizontalInput);
  }

  private void FixedUpdate()
 { float x = horizontalInput * moveSpeed;
   float y = _rigidbody2d.linearVelocity.y;
   _rigidbody2d.linearVelocity = new Vector2(x,y);
   if (isJumpPressed)
   {
    _rigidbody2d.linearVelocity = new Vector2(_rigidbody2d.linearVelocity.x, JumpForce);
    isJumpPressed = false;
   }

 }

 }