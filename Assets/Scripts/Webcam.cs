using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour {

    private WebCamTexture webcamTexture;
	private HeartRateProcessor processor;


	// Use this for initialization
	void Start () {
        webcamTexture = new WebCamTexture();
        webcamTexture.Play();

		processor=new HeartRateProcessor();
		processor.Init(webcamTexture.width,webcamTexture.height);

        renderer.material.mainTexture = webcamTexture;
        InvokeRepeating("ProcessImage", 0.0f, 0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void ProcessImage()
    {
		if (webcamTexture.didUpdateThisFrame){
			processor.Process(webcamTexture);

		}

    }
}
