using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDecorator : BaseHead
{
    public BaseHead head;

    public HeadDecorator(BaseHead head)
    {
        this.head = head;
    }

    public override void Use()
    {
        head.Use();
    }
}
