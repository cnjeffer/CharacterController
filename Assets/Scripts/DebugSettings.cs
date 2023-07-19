using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class DebugSettings : MonoBehaviour
{
    [SerializeField]
    public bool enableDebug;

    public GameObject DebugPanel;
    public PlayerMovement playerMovementStats;

    private void Start()
    {
        DebugPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (enableDebug)
            {
                enableDebug = false;
                DebugPanel.SetActive(false);
                return;
            }

            if (!enableDebug)
            {
                enableDebug = true;
                DebugPanel.SetActive(true);
            }


        }

        if (enableDebug) 
        { 
            Debug.Log("Move Speed:" + playerMovementStats.playerVelocity);
            Debug.Log("State:" + playerMovementStats.state);
        }
    }
}
