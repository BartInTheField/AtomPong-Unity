using UnityEngine;
using UnityAtoms.BaseAtoms;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private string axisKey;
    [SerializeField] private FloatVariable speed;

    private Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float velocity = Input.GetAxisRaw(axisKey);
        _rigidBody.velocity = new Vector2(0, velocity) * speed.Value;
    }
}