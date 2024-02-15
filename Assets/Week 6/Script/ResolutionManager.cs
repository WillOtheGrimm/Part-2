
using UnityEngine;

public class ResolutionManager : MonoBehaviour
{

    public int width;
    public int height;

    public void SetWidth(int newwidth)
    {
        width = newwidth;
    }

    public void SetHeight(int newHeight)
    {
        height = newHeight;
    }

    public void SetRes()
    {
        Screen.SetResolution(width, height, false);

    }
   
}
