// Created by Victor Engström. This educational version is for non-commercial use only.
// Copyright 2024 Sonigon AB. Please buy the full version to get all features and to support developement.
// https://assetstore.unity.com/packages/tools/audio/sonity-audio-middleware-229857

#if UNITY_EDITOR

using UnityEditor;

namespace Sonity.Internal {

    [CustomEditor(typeof(SoundDataGroup))]
    [CanEditMultipleObjects]
    public class SoundDataGroupEditor : SoundDataGroupEditorBase {

    }
}
#endif