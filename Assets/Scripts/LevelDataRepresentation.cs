using UnityEngine;
using System;
[Serializable]
public class LevelDataRepresentation
{
    public Vector2 playerStartPosition;
    public CameraSettingsRepresentation cameraSettings;
    public LevelItemRepresentation[] levelItems;
}