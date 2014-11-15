using UnityEngine;
using System.Collections;

public class HeartRateProcessor{

	Color[] imageBuffer;

	public void Init(int bufferWidth,int bufferHeight)
	{
		imageBuffer=new Color[bufferWidth*bufferHeight];
	}


	public void Process(WebCamTexture texture)
	{
		imageBuffer=texture.GetPixels();
		GetFocusLocation();
		ReadHeartRate();
	}

	public void GetFocusLocation()
	{
	}
}
