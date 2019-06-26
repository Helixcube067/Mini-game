using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tracer : MonoBehaviour {
    public Text activeText;
    public Text timerText;
    public Intertwerp stalker;
    public HazardBehavior timer;
	void Update () {
        activeText.text = "Follwing: " + stalker.enabled.ToString();
        timerText.text = "Stun timer left: " + timer.GetTimer();
    }
}
