using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ImageFader : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public float Delay = 0;

    public void ImageRecognized()
    {
        spriteRenderer.DOFade(1, 0.5f).SetDelay(Delay);
    }

    public void ImageRecogStopped()
    {
        spriteRenderer.DOFade(0, 0);
    }
}
