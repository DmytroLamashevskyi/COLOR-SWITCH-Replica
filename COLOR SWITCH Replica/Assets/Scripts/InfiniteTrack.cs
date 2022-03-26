using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteTrack : MonoBehaviour
{
    public List<GameObject> TrackObjects = new List<GameObject>(); 
    public GameObject LastCreated;
    public Player player;
     
    public void Update()
    {
        if(player.MaxPosition + 4 > LastCreated.transform.position.y )
        {
            CreateNext();
        }
    } 

    
    public void CreateNext()
    {
        int loopMax = 200;
        GameObject prefab;
        do
        {
            prefab = TrackObjects[Random.Range(0, TrackObjects.Count)];
            loopMax--;

        } while (prefab.name == LastCreated.name && loopMax > 0);

        var y = LastCreated.transform.position.y + 6; 
        LastCreated = Instantiate(prefab, new Vector3(0, y, 0), Quaternion.identity);  
    }

}
