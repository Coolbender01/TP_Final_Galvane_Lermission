using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VO_BabblesHudTrigger : MonoBehaviour
{

    bool audioHudTriggerEnter = false;
    bool audioHudTriggerExit = false;

    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }

    public void seq1()
    {
        AkSoundEngine.ExecuteActionOnEvent("VO_Hud_Seq1", AkActionOnEventType.AkActionOnEventType_Stop, gameObject);

        if (!audioHudTriggerEnter)
        {
            AkSoundEngine.PostEvent("VO_Hud_Seq1", gameObject);
            audioHudTriggerEnter = true;
        }
        else
        {
            return;
        }
    }

    public void seq2()
    {
        AkSoundEngine.ExecuteActionOnEvent("VO_Hud_Seq2", AkActionOnEventType.AkActionOnEventType_Stop, gameObject);

        if (!audioHudTriggerEnter)
        {
            AkSoundEngine.PostEvent("VO_Hud_Seq2", gameObject);
            audioHudTriggerEnter = true;
        }
        else
        {
            return;
        }
    }

    public void triggerIn()
    {
        AkSoundEngine.PostEvent("SFX_Hud_TriggerIn", gameObject);
    }

    public void triggerOut()
    {
        if (!audioHudTriggerExit)
        {
            AkSoundEngine.PostEvent("SFX_Hud_TriggerOut", gameObject);
            audioHudTriggerExit = true;
        }
        else
        {
            return;
        }
    }
}
