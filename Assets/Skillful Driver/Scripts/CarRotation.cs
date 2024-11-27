using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SkillfulDriver
{
    public class CarRotation : MonoBehaviour
    {
        //This script is used to rotate the car game object when player turns the steering wheel
        private float rot = 0;
        public float turnSpeed = 300f;
        private bool isTurningLeft = false;
        private bool isTurningRight = false;
        private float targetRotation = 0;
        private float turnInput=0;
        private float targetTurnInput = 0f;
        
        void Update()
        {
            turnInput = Input.GetAxis("Horizontal");
            
            // turnInput = Mathf.Lerp(turnInput, targetTurnInput, Time.deltaTime * 1f);
            
            rot -= turnInput * turnSpeed * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, rot), turnSpeed * Time.deltaTime);
            
            /*rot -= SteeringWheel.axis * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, rot + transform.rotation.z * Mathf.Rad2Deg), 200 * Time.deltaTime);*/
        }
        
        public void TurnLeft()
        {
            targetTurnInput = -1f;
            isTurningLeft = true;
            isTurningRight = false;
        }

        public void TurnRight()
        {
            targetTurnInput = 1f;
            isTurningRight = true;
            isTurningLeft = false;
        }
        
        public void StopTurning()
        {
            targetTurnInput = 0f;
            isTurningLeft = false;
        }

        public void StopRightTurning()
        {
            targetTurnInput = 0f;
            isTurningRight = false;
        }
    }
}
