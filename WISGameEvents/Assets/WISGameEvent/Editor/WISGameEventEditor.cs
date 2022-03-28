using UnityEngine;
using UnityEditor;

namespace WIS.Utils.Events {
    [CustomEditor(typeof(BaseGameEventHandler))]

    public class WISGameEventEditor : Editor {

        public override void OnInspectorGUI() {
            base.OnInspectorGUI();

            var handler = (BaseGameEventHandler) target;
            handler.GenerateTemplateTextAssets();

            if (string.IsNullOrEmpty(handler.eventName)) return;
            if (string.IsNullOrEmpty(handler.scriptLocation)) return;
            if (!AssetDatabase.IsValidFolder(handler.scriptLocation)) return;

            if (GUILayout.Button("Generate Event Scripts")) {
                handler.GenerateEventScripts();
                handler.ClearData();
            }
        }
    }
}
