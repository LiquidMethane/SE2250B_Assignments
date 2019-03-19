using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Share : MonoBehaviour
{
    private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";

    public void ShareToTW()
    {
        string nameParameter = "I Scored " + ScoreManager.HIGH_SCORE + " on Solitaire Prospector";
        Application.OpenURL(TWITTER_ADDRESS + "?text=" + WWW.EscapeURL(nameParameter));
    }

    


}
