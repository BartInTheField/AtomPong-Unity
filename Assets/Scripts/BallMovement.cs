using UnityEngine;
using UnityAtoms.BaseAtoms;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private FloatVariable speed;
    [SerializeField] private GameObjectPairEvent onBallCollideEvent;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Go(Vector2.right);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        onBallCollideEvent.Raise(new GameObjectPair()
        {
            Item1 = this.gameObject,
            Item2 = other.gameObject
        });
    }

    public void Go(Vector2 movement)
    {
        rb.velocity = movement * speed.Value;
    }
}
