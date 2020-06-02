using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using Pada1.BBCore.Tasks;
using Pada1.BBCore.Framework;

[Action("SetActiveMusic")]
public class SetActiveMusic : BasePrimitiveAction
{

    [InParam("valor")]
    public bool valor;

    [InParam("gameObject")]
    public GameObject musica;

    public override TaskStatus OnUpdate()
    {
        GlobalBlackboard.musicActive = valor;
        //musica.SetActive(valor);
        if(valor)
            musica.gameObject.GetComponent<AudioSource>().Play();
        else
            musica.gameObject.GetComponent<AudioSource>().Stop();
        return TaskStatus.COMPLETED;
    }


}

