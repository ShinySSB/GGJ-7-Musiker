// Created by Victor Engstr�m. This educational version is for non-commercial use only.
// Copyright 2024 Sonigon AB. Please buy the full version to get all features and to support developement.
// https://assetstore.unity.com/packages/tools/audio/sonity-audio-middleware-229857

using UnityEngine;

namespace ExampleSonity {

    [AddComponentMenu("")]
    public class ExampleLegacyBoxColliderSize : MonoBehaviour {

        public Vector3 boxColliderSize = new Vector3(1f, 1f, 1f);

        // Unity has a bug where if you downgrade a project box colliders might set the box colliders to size 2,2,2 instead of 1,1,1.
        private void Start() {
            BoxCollider boxCollider = GetComponent<BoxCollider>();
            if (boxCollider != null ) {
                boxCollider.size = boxColliderSize;
            }
        }
    }
}