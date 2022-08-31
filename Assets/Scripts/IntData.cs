//This code enables the creation of IntData files
using UnityEngine;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
  
    public int value;

    public void UpdateValue(int num)
    {
    
        value += num;
    }
}