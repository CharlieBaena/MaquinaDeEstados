using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using Pada1.BBCore.Tasks;
using Pada1.BBCore.Framework;

[Condition("IsEnemyChasing")]
public class IsEnemyChasing : ConditionBase
{

    public override bool Check()
    {
        return GlobalBlackboard.enemyChasing;
    }

}
