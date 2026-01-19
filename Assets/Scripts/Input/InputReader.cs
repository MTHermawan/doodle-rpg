using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


[CreateAssetMenu(fileName = "InputReader", menuName = "System/Input Reader")]
public class InputReader : ScriptableObject
{
    [SerializeField] private InputActionAsset mainInputAction;
    private InputAction positiveAction;
    public event UnityAction OnPositiveInput;

    private void positiveCallback(InputAction.CallbackContext context)
    {
        if (context.started&&OnPositiveInput!=null)
        {
            OnPositiveInput?.Invoke();
        }        
    }
    void OnEnable()
    {
        positiveAction = mainInputAction.FindAction("Positive");
        positiveAction.started += positiveCallback;
        positiveAction.performed += positiveCallback;
        positiveAction.canceled += positiveCallback;
    }

    void OnDisable()
    {
        positiveAction.started += positiveCallback;
        positiveAction.performed += positiveCallback;
        positiveAction.canceled += positiveCallback;
        positiveAction.Disable();
    }
}
