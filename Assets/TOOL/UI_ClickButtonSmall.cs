using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ClickButtonSmall : MonoBehaviour
{
    // Start is called before the first frame update
        void Start()
        {
            AkSoundEngine.RegisterGameObj(gameObject);
        }
        public void onClick()
        {
            AkSoundEngine.PostEvent("UI_ConfirmSmall", gameObject);
        }
        public void onMouseOver()
        {
             AkSoundEngine.PostEvent("UI_Highlight", gameObject);
        }
}
