using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed = 7.4f;
    public float deleteTimer = 0f;
    public float deleteTimerTime = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up * bulletSpeed) * Time.deltaTime;
        if (deleteTimer < deleteTimerTime) {
            deleteTimer += Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }
}
