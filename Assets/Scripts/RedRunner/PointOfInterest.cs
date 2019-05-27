using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOfInterest : Subject
{
    [SerializeField]
    private string poiName;

    public void Achieved()
    {
        Notify(poiName, NotificationType.AchievementUnlocked);
    }
}
