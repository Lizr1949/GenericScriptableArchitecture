﻿namespace GenericScriptableArchitecture
{
    using UnityEngine;

    public abstract class BaseEventInstancer : MonoBehaviour
    {
        internal abstract ScriptableEventHelper ScriptableEventHelper { get; }
    }
}