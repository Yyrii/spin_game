using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Skill_button_handler : MonoBehaviour{
    public bool condition = false;
    public static float skill_speed = 0f;


    IEnumerator Activate_skill()
    {
        skill_speed = 10f;
        yield return new WaitForSeconds(3f);
        skill_speed = 0f;
    }
    public void boost_speed(bool condition){
        if (condition == true){
            StartCoroutine(Activate_skill());
            skill_speed = 10f;
        }

    }
}
