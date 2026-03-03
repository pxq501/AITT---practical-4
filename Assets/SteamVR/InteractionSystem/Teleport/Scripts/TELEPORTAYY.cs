using UnityEngine;
using Valve.VR;

public class TELEPORTAYY : MonoBehaviour
{

    void Update()
    {
        if (SteamVR_Input.GetStateDown("offroadteleport", SteamVR_Input_Sources.RightHand))
        {
            print("Fire out the teleport line");
        }

        if (SteamVR_Input.GetStateUp("offroadteleport", SteamVR_Input_Sources.RightHand))
        {
            print("Teleport to line intersection");
        }

        Ray raycast = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        bool bHit = Physics.Raycast(raycast, out hit);
        if (bHit)
        {
            print(hit.point);
        }
    }
}