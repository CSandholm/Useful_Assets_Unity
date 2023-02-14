using UnityEngine;
using System.Collections;
 
public class camerazoom : MonoBehaviour 
{
    public static camerazoom instance;

    public void zoomout()
    {
        StartCoroutine(ZoomCamera(0.3f, 0.54f, 1, 100));
    }
    public void zoomin()
    {
        StartCoroutine(ZoomCamera(0.54f,0.3f, 1, 100));
    }


    IEnumerator ZoomCamera(float from, float to, float time, float steps)
    {
        float f = 0;
 
        while (f <= 1)
        {
            Camera.main.orthographicSize = Mathf.Lerp(from, to, f);
 
            f += 1f/steps;
 
            yield return new WaitForSeconds(time/steps);
        }
    }
}
