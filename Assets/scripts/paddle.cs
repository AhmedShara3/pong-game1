using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
     public float speed = 8f;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        
    }
    public void ResetPosition()
    {
        rb.linearVelocity = Vector2.zero;
        rb.position = new Vector2(rb.position.x, 0.0f);
    }

 
}
