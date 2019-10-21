using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spinning : MonoBehaviour{
    private float skill_speed = 0.01f;
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position += movement * Time.deltaTime * Parameters.movement_speed;
        transform.Rotate(0, 0, Parameters.transform_speed + Skill_button_handler.skill_speed);
    }
}
