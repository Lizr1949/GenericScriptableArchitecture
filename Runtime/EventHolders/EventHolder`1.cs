﻿namespace GenericScriptableArchitecture
{
    using System;
    using UnityEngine;

    internal class EventHolderBaseOne { }

    [Serializable]
    internal class EventHolder<T> : EventHolderBaseOne
    {
        [SerializeField] private ScriptableEvent<T> _event;
        [SerializeField] private Variable<T> _variable;
        [SerializeField] private EventTypes _type = EventTypes.ScriptableEvent;
        [SerializeField] private bool _notifyCurrentValue;

        public void AddListener(ScriptableEventListener<T> listener)
        {
            switch (_type)
            {
                case EventTypes.ScriptableEvent:
                    _event?.AddListener(listener);
                    break;

                case EventTypes.Variable:
                    _variable?.AddListener(listener, _notifyCurrentValue);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(listener),
                        "Unknown enum value when adding listener to the event holder.");
            }
        }

        public void RemoveListener(ScriptableEventListener<T> listener)
        {
            switch (_type)
            {
                case EventTypes.ScriptableEvent:
                    _event?.RemoveListener(listener);
                    break;

                case EventTypes.Variable:
                    _variable?.RemoveListener(listener);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(listener),
                        "Unknown enum value when adding listener to the event holder.");
            }
        }
    }
}