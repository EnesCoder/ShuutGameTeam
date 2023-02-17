using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public PlayerScript ps;
    public Text canShootInTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ps.ShootTimer >= 8f) {
            canShootInTxt.text = "Can Shoot In:\nReady";
        }
        else {
            canShootInTxt.text = "Can Shoot In:\n"+ps.ShootTimer.ToString("0");
        }
    }
}
