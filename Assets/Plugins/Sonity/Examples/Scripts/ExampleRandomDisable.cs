// Created by Victor Engström. This educational version is for non-commercial use only.
// Copyright 2024 Sonigon AB. Please buy the full version to get all features and to support developement.
// https://assetstore.unity.com/packages/tools/audio/sonity-audio-middleware-229857

using UnityEngine;

namespace ExampleSonity {

    [AddComponentMenu("")]
    public class ExampleRandomDisable : MonoBehaviour {

        public GameObject gameObjectToDisable;
        bool isActive = true;
        float timeCurrent = 1f;

        void Update() {
            if (gameObjectToDisable != null) {
                // Toggles the object from enabled to disabled randomly
                if (timeCurrent <= 0f) {
                    isActive = !isActive;
                    gameObjectToDisable.SetActive(isActive);
                    timeCurrent = Random.Range(2f, 3f);
                }
                timeCurrent -= Time.deltaTime;
            }
        }
    }
}