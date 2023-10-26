using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SceneManagment
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup canvasGroup = null;
        void Awake()
        {
            canvasGroup= GetComponent<CanvasGroup>();

        }

       
        public void FadeOutImmediate()
        {
            canvasGroup.alpha = 1.0f;
        }
        public IEnumerator FadeOut(float time)
        {
            while (canvasGroup.alpha < 1f)
            {

                canvasGroup.alpha += Time.deltaTime/time;
                yield return null;
            }
        }


        public IEnumerator FadeIn(float time)
        {
            while (canvasGroup.alpha>0)
            {

                canvasGroup.alpha -= Time.deltaTime / time;
                yield return null;
            }
        }
    }

}