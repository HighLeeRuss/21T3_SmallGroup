// GENERATED AUTOMATICALLY FROM 'Assets/Team Members/Maya/PlayerTestControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerTestControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerTestControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerTestControls"",
    ""maps"": [
        {
            ""name"": ""Player1Gameplay"",
            ""id"": ""51d4e95e-f30a-41dd-b021-c88efd2c6d99"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""36d1aafd-7e9a-49af-b1d2-846ddaee3071"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8e1696ae-a367-4fba-a900-68cc5474ea12"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Hold(duration=0.01)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e1571f92-26fc-4f43-8cd8-71f4c7143333"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8e41ae59-7aaf-4d22-885d-cb5059a8d789"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""445ad200-1e7f-43a4-a896-7168d2ddc7f8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5b3027b-a372-4c87-9ac5-6fcb8c24df94"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1Gameplay
        m_Player1Gameplay = asset.FindActionMap("Player1Gameplay", throwIfNotFound: true);
        m_Player1Gameplay_Move = m_Player1Gameplay.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player1Gameplay
    private readonly InputActionMap m_Player1Gameplay;
    private IPlayer1GameplayActions m_Player1GameplayActionsCallbackInterface;
    private readonly InputAction m_Player1Gameplay_Move;
    public struct Player1GameplayActions
    {
        private @PlayerTestControls m_Wrapper;
        public Player1GameplayActions(@PlayerTestControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player1Gameplay_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player1Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1GameplayActions instance)
        {
            if (m_Wrapper.m_Player1GameplayActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player1GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player1GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player1GameplayActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player1GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public Player1GameplayActions @Player1Gameplay => new Player1GameplayActions(this);
    public interface IPlayer1GameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
