using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class CubeController : OVRGrabbable
{
    private GameController scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("GameController").GetComponent<GameController>();

    }

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint){
        GameController controller = new GameController();
        base.GrabBegin(hand,grabPoint);
        controller.OnCubeGrabbed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
