using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cam;
    [SerializeField] float zoomedOut = 60f;
    [SerializeField] float zoomedIn = 20f;

    bool zoomedInToggle = false;

    private void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(!zoomedInToggle)
            {
                zoomedInToggle = true;
                cam.m_Lens.FieldOfView = zoomedIn;
            }
            else
            {
                zoomedInToggle = false;
                cam.m_Lens.FieldOfView = zoomedOut;
            }
        }
    }
}
