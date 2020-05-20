using UnityAtoms.BaseAtoms;
using UnityEngine;

[CreateAssetMenu(menuName = "Unity Atoms/Ball/Actions/ChangeBallAngle")]
public class ChangeBallAngleAction : GameObjectPairAction
{
    [SerializeField] private FloatVariable bounceOffSpeed;

    public override void Do(GameObjectPair gameObjectPair)
    {
        GameObject self = gameObjectPair.Item1;
        GameObject other = gameObjectPair.Item2;

        if (!other || !other.gameObject.CompareTag("Player"))
            return;

        // Hit the left Racket?
        if (other.gameObject.name == "Player 1")
        {
            // Calculate hit Factor
            float y = HitFactor(self.transform.position,
                                other.transform.position,
                                other.GetComponent<Collider2D>().bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            self.GetComponent<Rigidbody2D>().velocity = dir * bounceOffSpeed.Value;
        }

        // Hit the right Racket?
        if (other.gameObject.name == "Player 2")
        {
            // Calculate hit Factor
            float y = HitFactor(self.transform.position,
                                other.transform.position,
                                other.GetComponent<Collider2D>().bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            self.GetComponent<Rigidbody2D>().velocity = dir * bounceOffSpeed.Value;
        }
    }


    float HitFactor(Vector2 ballPos, Vector2 racketPos,
            float racketHeight)
    {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }
}

