﻿using UnityEngine;
//
//For easily accesing local head and hand anchors
//
namespace Networking.Pun2
{
    public class OculusPlayer : MonoBehaviour
    {
        public GameObject head;
        public GameObject rightHand;
        public GameObject leftHand;
        public GameObject heart;

        public static OculusPlayer instance;

        private void Awake()
        {
            if (instance == null)
                instance = this;
        }

        private void OnDestroy()
        {
            if (instance == this)
                instance = null;
        }
    }
}
