using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FootstepCollectionEntry
{
    public string textureName;
    public AK.Wwise.Switch footstepCollection;
}

public class FootstepTerrain : MonoBehaviour
{
    public AudioClip defaultSound;
    public List<FootstepCollectionEntry> collections;

    private AK.Wwise.Switch currentCollection;
    /*private TerrainCheckData terrainCheck;*/
    private string currentLayer;
    // Start is called before the first frame update
  /*  void Start()
    {
        terrainCheck = new TerrainCheckData();
    }*/

    public void CheckLayers()
    {
        //raycast down
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.5f))
        {
            /*if (hit.transform.GetComponent<Terrain>() != null)
            {
                Terrain t = hit.transform.GetComponent<Terrain>();
                if (currentLayer != terrainCheck.GetLayerName(transform.position, t))
                {
                    currentLayer = terrainCheck.GetLayerName(transform.position, t);
                    currentCollection = null;
                    foreach (FootstepCollectionEntry fc in collections)
                    {
                        if (currentLayer == fc.textureName)
                        {
                            currentCollection = fc.footstepCollection;
                            break;
                        }
                    }
                }
            */
            }
            else if (currentLayer != LayerMask.LayerToName(hit.transform.gameObject.layer))
            {
                currentLayer = LayerMask.LayerToName(hit.transform.gameObject.layer);
                currentCollection = null;
                foreach (FootstepCollectionEntry fc in collections)
                {
                    if (currentLayer == fc.textureName)
                    {
                        currentCollection = fc.footstepCollection;
                        break;
                    }
                }
            }

        }
    /*
    }
      
    private List<AudioClip> GetDefaultSound()
    {
        List<AudioClip> defaultList = new List<AudioClip>();
        defaultList.Add(defaultSound);
        return defaultList;
    }
    public List<AudioClip> GetWalkFootsteps()
    {
        CheckLayers();
        if (currentCollection != null)
        {
            return currentCollection.walkClips;
        }
        return GetDefaultSound();
    }
    public List<AudioClip> GetRunFootsteps()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.runClips;
        return GetDefaultSound();
    }
    public AudioClip GetJumpFootstep()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.jumpClip;
        return defaultSound;
    }
    public AudioClip GetLandFootstep()
    {
        CheckLayers();
        if (currentCollection != null)
            return currentCollection.landClip;
        return defaultSound;
    }
    */
}
