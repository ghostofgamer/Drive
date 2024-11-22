using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailySpinScreen : MonoBehaviour
{
    private CanvasGroup _canvasGroup;

    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void Open()
    {
        ChangeValue(1, true);
    }

    public void Close()
    {
        ChangeValue(0, false);
    }

    private void ChangeValue(int alpha, bool value)
    {
        _canvasGroup.alpha = alpha;
        _canvasGroup.interactable = value;
        _canvasGroup.blocksRaycasts = value;
    }
}