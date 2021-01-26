using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootstepSounds : MonoBehaviour
{
    [FMODUnity.EventRef]
    [SerializeField] string FootstepEvent = "";
    [SerializeField] float footstepDistance = 1f;

    Vector3 lastSoundPosition;
    // Start is called before the first frame update
    void Start()
    {
    	    
    }

    // Update is called once per frame
    void Update()
    {
	float distance = Vector3.Distance(transform.position, lastSoundPosition);
	if(distance > footstepDistance)
	{
            Debug.Log("Test");
	    FMODUnity.RuntimeManager.PlayOneShot(FootstepEvent, transform.position);
	    lastSoundPosition = transform.position;
	}
    }
}
