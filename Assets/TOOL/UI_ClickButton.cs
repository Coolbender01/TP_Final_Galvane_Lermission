using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ClickButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }
    public void onClick()
    {
        AkSoundEngine.PostEvent("UI_Confirm", gameObject);
    }

    public void onMouseOver()
    {
        AkSoundEngine.PostEvent("UI_Highlight", gameObject);
    }
}
