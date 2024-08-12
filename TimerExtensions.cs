using System;
using System.Collections;
using UnityEngine;

public static class TimerExtensions
{
    public static Coroutine StartTimer(this MonoBehaviour behavior, float seconds, Action callback)
    {
        IEnumerator task()
        {
            while (seconds > 0f)
            {
                seconds -= Time.deltaTime;
                yield return null;
            }
            callback?.Invoke();
        }

        return behavior.StartCoroutine(task());
    }
}