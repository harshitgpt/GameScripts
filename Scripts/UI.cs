using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField]
    GameObject backPanel, homeButton, replayButton,
    star1, star2, star3, score, coins, gems, colorWheel, levelSucess;

    public AudioSource rewards;

    void Start()
    {
        
        LeanTween.scale(levelSucess, new Vector3(4f, 3f, 3f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic).setOnComplete(LevelComplete);
        LeanTween.moveLocal(levelSucess, new Vector3(-4f, 370f, -3f), 0.3f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(levelSucess, new Vector3(4f, 3f, 3f), 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCubic);

    }

    void LevelComplete()
    {
        
        LeanTween.moveLocal(backPanel, new Vector3(0f, -58f, -2f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc).setOnComplete(StarsAnim);
        LeanTween.scale(homeButton, new Vector3(0.5f, 1.3f, 0.85f), 2f).setDelay(.8f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(replayButton, new Vector3(0.5f, 1.3f, 0.85f), 2f).setDelay(.9f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.alpha(score.GetComponent<RectTransform>(), 1f, .5f).setDelay(1f);
        LeanTween.alpha(coins.GetComponent<RectTransform>(), 1f, .5f).setDelay(1.1f);
        LeanTween.alpha(gems.GetComponent<RectTransform>(), 1f, .5f).setDelay(1.2f);
    }


    void StarsAnim()
    {

        rewards.Play();
        LeanTween.scale(star1, new Vector3(0.6f, 0.6f, 0.6f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star2, new Vector3(0.6f, 0.6f, 0.6f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(star3, new Vector3(0.6f, 0.6f, 0.6f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
       



    }
}
