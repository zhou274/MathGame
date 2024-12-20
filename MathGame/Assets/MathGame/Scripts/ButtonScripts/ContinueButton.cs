using AppAdvisory.MathGame;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : ButtonHelper
{
    override public void OnClicked()
    {
        GameManager.isContinue = true;
        print("OnClicked : " + gameObject.name);
        menuManager.GoToGame();
        RemoveListener();
    }
}
