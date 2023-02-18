using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float MoveTimer = 0f;
    public float MoveRate = 2f;

    public float enemySpeed = 0.9f;

    public SpriteRenderer Sr;
    public Sprite anim1;
    public Sprite anim2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTimer += Time.deltaTime;
        if (MoveTimer >= MoveRate) {
            MoveTimer = 0f;
            int randPosition = Random.Range(0, 4);
            if (randPosition == 0) {
                transform.position = new Vector2(transform.position.x + enemySpeed, transform.position.y);
            }
            if (randPosition == 1) {
                transform.position = new Vector2(transform.position.x - enemySpeed, transform.position.y);
            }
            if (randPosition == 2) {
                transform.position = new Vector2(transform.position.x, transform.position.y + enemySpeed);
            }
            if (randPosition == 3) {
                transform.position = new Vector2(transform.position.x, transform.position.y - enemySpeed);
            }

            if (Sr.sprite != anim1) {
                Sr.sprite = anim1;
            }
            else {
                Sr.sprite = anim2;
            }
        }
    }
}
