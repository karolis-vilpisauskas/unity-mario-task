using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

public class EndingController : MonoBehaviour
{
    public PlayableDirector playable;
    public PlayableDirector playableBig;
    public GameObject player;
    public bool isPoweredUp = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        // Disable user input
        PlayerController controller = collision.gameObject.GetComponent<PlayerController>();
        controller.isInputDisabled = true;

        // Set position offset
        isPoweredUp = controller.poweredUp;

        float x = player.transform.position.x;
        float y = player.transform.position.y;

        string trackName = "Recorded (3)";
        Vector3 trackOffset = new Vector3(x, y, 0f);

        SetOffset(trackName, trackOffset);

        // Play timeline
        if (controller.poweredUp)
            playableBig.Play();
        else playable.Play();
    }

    private void LateUpdate()
    {
        // Don't allow the player to slide down less than -1
        PlayableDirector timeline = playable;
        if (isPoweredUp)
            timeline = playableBig;

        if (player.transform.position.y < -1 && timeline.state.ToString() == "Playing" && timeline.time < 1.16666666666667)
            player.transform.position = new Vector3(player.transform.position.x, -1f, 0f);
        
    }

    public void SetOffset(string trackName, Vector3 offset)
    {
        // Get Timeline
        var timelineAsset = playable.playableAsset as TimelineAsset;

        if (isPoweredUp)
             timelineAsset = playableBig.playableAsset as TimelineAsset;
        
        // Loop Through Tracks and set offset of the correct one
        foreach (var track in timelineAsset.GetOutputTracks())
        {
            var animTrack = track as AnimationTrack;
            if (animTrack != null)
            {
                foreach (var clips in animTrack.GetClips())
                {
                    var animAsset = clips.asset as AnimationPlayableAsset;
                    if (animAsset && animAsset.name == trackName)
                    {
                        animAsset.position = offset;
                    }
                }
            }
        }
    }

}
