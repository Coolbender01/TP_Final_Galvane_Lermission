using System;
using UnityEngine;

public class SetState : MonoBehaviour
{

    private bool firstDead = false;

    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);
    }
    public void outFight()
    {
        AkSoundEngine.SetState("MusicGroup", "Music_Level1");
    }

    public void outFightFinal()
    {
        if (firstDead == false)
        {
            firstDead = true;
            return;
        }
        if (firstDead == true)
        {
            AkSoundEngine.SetState("MusicGroup", "Music_Level2");
        }
    }
}

