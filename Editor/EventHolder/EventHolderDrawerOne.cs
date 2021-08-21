﻿namespace GenericScriptableArchitecture.Editor
{
    using UnityEditor;
    using UnityEngine;

    [CustomPropertyDrawer(typeof(EventHolderBaseOne), true)]
    public class EventHolderDrawerOne : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var helper = new EventHolderDrawerUtil(property, 1);
            return helper.GetPropertyHeight();
        }

        public override void OnGUI(Rect fieldRect, SerializedProperty property, GUIContent label)
        {
            var helper = new EventHolderDrawerUtil(property, 1);
            helper.DrawButtonAndValue(fieldRect, label);
        }
    }
}