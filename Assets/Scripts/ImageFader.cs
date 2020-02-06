using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ImageFader : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public void ImageRecognized()
    {
        spriteRenderer.DOFade(1, 0.5f);
    }

    public void ImageRecogStopped()
    {
        spriteRenderer.DOFade(0, 0);
    }
}
