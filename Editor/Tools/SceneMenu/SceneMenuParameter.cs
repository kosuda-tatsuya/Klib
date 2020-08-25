﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace klib
{
    [CreateAssetMenu(fileName = "SceneMenuParameter", menuName = "EditorSettings/SceneMenuParameter")]
    public class SceneMenuParameter : ScriptableObject
    {
        public string[] searchPath;
    }
}
