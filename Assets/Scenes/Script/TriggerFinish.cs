using UnityEngine;
using UnityEngine.UI;

public class TriggerFinish : MonoBehaviour
{
    public TriggerStart _triggerStart;
    
    public GameObject Player;
    public Text OverText;
    public Text TimeText;
    public Text Speed;
    public Canvas GameOverCanvas;
    void OnTriggerEnter(Collider other) {
        Player.GetComponent<PrometeoCarController>().enabled = false;
        FindObjectOfType<Camera>().GetComponent<BlurCamera>().enabled = true;
        OverText.text = "Finish";
        Speed.enabled = false;
        TimeText.enabled = false;
        GameOverCanvas.enabled = true;
        _triggerStart.Active = false;
    }
}
