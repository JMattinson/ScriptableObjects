//This code enables the creation of Float files
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
  
  public float value;

  public void UpdateValue(float num)
  {
    
    value += num;
  }
}
