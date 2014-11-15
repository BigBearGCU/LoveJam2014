using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour {

    private WebCamTexture webcamTexture;


	// Use this for initialization
	void Start () {
        webcamTexture = new WebCamTexture();
        webcamTexture.Play();

        renderer.material.mainTexture = webcamTexture;
        InvokeRepeating("ProcessImage", 0.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ProcessImage()
    {
        Color[] data = webcamTexture.GetPixels();

    }
}
