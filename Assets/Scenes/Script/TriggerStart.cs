using UnityEngine;
using UnityEngine.UI;


public class TriggerStart : MonoBehaviour
{
    public bool Active = false;
    public GameObject Player;
    public Text TimeText;
    public Text OverText;
    public Text Speed;
    public Canvas GameOverCanvas;
    private float _time = 10;
    void OnTriggerEnter(Collider other)
    {
        Active = true;
    }
    private void Update()
    {
        if (Active)
        {
            TimeText.text = Mathf.Round(_time) + "sec";
            _time -= Time.deltaTime; 
            
            if(_time < 0)
            {
                Player.GetComponent<PrometeoCarController>().enabled = false;
                FindObjectOfType<Camera>().GetComponent<BlurCamera>().enabled = true;
                
                OverText.text = "Time left";
                Speed.enabled = false;
                TimeText.enabled = false;
                GameOverCanvas.enabled = true;
                Active = false;
            }
            
            
            
        }
    }
}
