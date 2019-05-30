using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    private void Start()
    {
        foreach (var poi in GameObject.FindObjectsOfType<Subject>())
        {
            poi.RegisterObserver(this);
        }

        
    }
    public override void OnNotify(object value, NotificationType notificationType)
    {
       if(notificationType == NotificationType.AchievementUnlocked)
        {
            Debug.Log("Unlocked " + value);
        }
    }

}
public enum NotificationType
{
    AchievementUnlocked
}
