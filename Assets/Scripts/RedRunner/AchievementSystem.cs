using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementSystem : Observer
{
    private void Start()
    {

        //TODO delete player prefs

        foreach (var poi in FindObjectsOfType<PointOfInterest>())
        {
            poi.RegisterObserver(this);
        }

        
    }
    public override void OnNotify(object value, NotificationType notificationType)
    {
       if(notificationType == NotificationType.AchievementUnlocked)
        {
            string achievementKey = "achivement-" + value;

            Debug.Log("Unlocked " + value);
        }
    }

}
public enum NotificationType
{
    AchievementUnlocked
}
