using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Object _object;

    public string Label => _label;
    public Sprite Icon => _icon;
    public Object Type => _object;

    public event UnityAction Disabled;

    public enum Object
    {
        GreenKeyCard,
        BlueKeyCard,
        RedKeyCard,
        ScrapMetal
    }

    public void Disable()
    {
        gameObject.SetActive(false);
        Disabled?.Invoke();
    }
}
