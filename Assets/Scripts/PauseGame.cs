using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PauseGame : MonoBehaviour
{
    GameObject player;
    StarterAssets.StarterAssetsInputs starterAssetsInputs;
    bool gamePaused = false;
 
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        starterAssetsInputs = player.GetComponent<StarterAssets.StarterAssetsInputs>();
        UnPause();
    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!gamePaused)
            {
                ProcessPause();
            }
            else
            {
                UnPause();
            }
        }
    }
 
    private void UnPause()
    {
        gamePaused = false;
        // setting cursor bool, in the starterAssetsInputs Script
        starterAssetsInputs.cursorLocked = true;
        starterAssetsInputs.cursorInputForLook = true;
 
        starterAssetsInputs.SetCursorState(starterAssetsInputs.cursorLocked);
    }
 
    private void ProcessPause()
    {
        gamePaused = true;
        starterAssetsInputs.cursorLocked = false;
        starterAssetsInputs.cursorInputForLook = false;
 
        starterAssetsInputs.SetCursorState(starterAssetsInputs.cursorLocked);
    }
}