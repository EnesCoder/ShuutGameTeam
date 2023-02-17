using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public float speed = 4f;

    public GameObject bullet;

    public SpriteRenderer sr;
    public Sprite walk1;
    public Sprite walk2;

    public float ShootTimer = 8f;
    bool startTimer = false;
    bool canShoot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + speed, player.transform.position.z);

            if (sr.sprite != walk1) {
                sr.sprite = walk1;
            }
            else {
                sr.sprite = walk2;
            }
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y - speed, player.transform.position.z);

            if (sr.sprite != walk1) {
                sr.sprite = walk1;
            }
            else {
                sr.sprite = walk2;
            }
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, player.transform.position.z);

            if (sr.sprite != walk1) {
                sr.sprite = walk1;
            }
            else {
                sr.sprite = walk2;
            }
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            player.transform.position = new Vector3(player.transform.position.x - speed, player.transform.position.y, player.transform.position.z);

            if (sr.sprite != walk1) {
                sr.sprite = walk1;
            }
            else {
                sr.sprite = walk2;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (canShoot) {
                spawnBullet();
                startTimer = true;
            }
        }

        if (startTimer) {
            ShootTimer -= Time.deltaTime;
            canShoot = false;
            if (ShootTimer <= 0) {
                canShoot = true;
                startTimer = false;
                ShootTimer = 8f;
            }
        }
    }

    public void spawnBullet() {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 0.4f, 0), transform.rotation);
    }
}
