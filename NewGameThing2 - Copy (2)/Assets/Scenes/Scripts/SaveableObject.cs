using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public enum ObjectType {Triangle, Circle, Square, Bouncy}
public abstract class SaveableObject : MonoBehaviour
{
    protected string save;

    [SerializeField]
    public ObjectType objectType;

    // Start is called before the first frame update
    private void Start()
    {
        SaveGameManager.Instance.SaveableObjects.Add(this);
        
    } 

    public virtual void Save(int id)
    {//0-10
       PlayerPrefs.SetString(id.ToString(), objectType + "_" + transform.position.ToString() + "_" + transform.localScale + "_" + transform.localRotation + "_" +save);
    }

    public virtual void Load(string[] values)
    {
        transform.localPosition = SaveGameManager.Instance.StringToVector(values[1]);
		transform.localScale = SaveGameManager.Instance.StringToVector(values[2]);
		transform.localRotation = SaveGameManager.Instance.StringToQuaternion(values[3]);
    }

    public static void DestroySaveable(int l)
    {
        SaveGameManager.Instance.SaveableObjects.RemoveAt(l);
        //Destroy(gameObject);
    }

}
