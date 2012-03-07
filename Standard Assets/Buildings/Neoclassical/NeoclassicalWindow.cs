using UnityEngine;

public sealed class NeoclassicalWindow : Base.FaceComponent
{
  public WindowFrame windowFrame;

  public NeoclassicalWindow (Base.Face parent, Vector3 dr, Vector3 dl)
    : base (parent)
  {
    height = parentBuilding.floorHeight * 0.5f;

    float height_modifier = 0.25f * parentFace.parentBuilding.floorHeight;

    boundaries.Add(new Vector3(dr.x, dr.y + height_modifier, dr.z));
    boundaries.Add(new Vector3(dl.x, dl.y + height_modifier, dl.z));
    boundaries.Add(new Vector3(dl.x, dl.y + height + height_modifier, dl.z));
    boundaries.Add(new Vector3(dr.x, dr.y + height + height_modifier, dr.z));

    windowFrame = new WindowFrame(this);
  }
}
