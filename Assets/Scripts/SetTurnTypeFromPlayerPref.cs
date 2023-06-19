using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnTypeFromPlayerPref : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;
    public bool Continuous=true;
    // Start is called before the first frame update
    void Start()
    {
        ApplyPlayerPref();
    }

    public void ApplyPlayerPref()
    {
         
            if(!Continuous)
            {
                snapTurn.leftHandSnapTurnAction.action.Enable();
                snapTurn.rightHandSnapTurnAction.action.Enable();
                continuousTurn.leftHandTurnAction.action.Disable();
                continuousTurn.rightHandTurnAction.action.Disable();
            }
            else if(Continuous) 
            {
                snapTurn.leftHandSnapTurnAction.action.Disable();
                snapTurn.rightHandSnapTurnAction.action.Disable();
                continuousTurn.leftHandTurnAction.action.Enable();
                continuousTurn.rightHandTurnAction.action.Enable();
                print("Continuous");
            }
    }

    public void ChangeTurn()
    {
        Continuous=!Continuous;
        ApplyPlayerPref();
    }
}
